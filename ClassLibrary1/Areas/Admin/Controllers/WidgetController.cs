﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ryn.Core.Domain.Cms;
using Ryn.Core.Events;
using Ryn.Services.Cms;
using Ryn.Services.Configuration;
using Ryn.Services.Plugins;
using Ryn.Services.Security;
using Ryn.Web.Areas.Admin.Factories;
using Ryn.Web.Areas.Admin.Models.Cms;
using Ryn.Web.Framework.Mvc;

namespace Ryn.Web.Areas.Admin.Controllers
{
    public partial class WidgetController : BaseAdminController
    {
        #region Fields

        private readonly IEventPublisher _eventPublisher;
        private readonly IPermissionService _permissionService;
        private readonly ISettingService _settingService;
        private readonly IWidgetModelFactory _widgetModelFactory;
        private readonly IWidgetPluginManager _widgetPluginManager;
        private readonly WidgetSettings _widgetSettings;

        #endregion

        #region Ctor

        public WidgetController(IEventPublisher eventPublisher,
            IPermissionService permissionService,
            ISettingService settingService,
            IWidgetModelFactory widgetModelFactory,
            IWidgetPluginManager widgetPluginManager,
            WidgetSettings widgetSettings)
        {
            _eventPublisher = eventPublisher;
            _permissionService = permissionService;
            _settingService = settingService;
            _widgetModelFactory = widgetModelFactory;
            _widgetPluginManager = widgetPluginManager;
            _widgetSettings = widgetSettings;
        }

        #endregion

        #region Methods

        public virtual IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public virtual async Task<IActionResult> List()
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

            //prepare model
            var model = await _widgetModelFactory.PrepareWidgetSearchModelAsync(new WidgetSearchModel());

            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> List(WidgetSearchModel searchModel)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return await AccessDeniedDataTablesJson();

            //prepare model
            var model = await _widgetModelFactory.PrepareWidgetListModelAsync(searchModel);

            return Json(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> WidgetUpdate(WidgetModel model)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

            var widget = await _widgetPluginManager.LoadPluginBySystemNameAsync(model.SystemName);
            if (_widgetPluginManager.IsPluginActive(widget, _widgetSettings.ActiveWidgetSystemNames))
            {
                if (!model.IsActive)
                {
                    //mark as disabled
                    _widgetSettings.ActiveWidgetSystemNames.Remove(widget.PluginDescriptor.SystemName);
                    await _settingService.SaveSettingAsync(_widgetSettings);
                }
            }
            else
            {
                if (model.IsActive)
                {
                    //mark as active
                    _widgetSettings.ActiveWidgetSystemNames.Add(widget.PluginDescriptor.SystemName);
                    await _settingService.SaveSettingAsync(_widgetSettings);
                }
            }

            var pluginDescriptor = widget.PluginDescriptor;

            //display order
            pluginDescriptor.DisplayOrder = model.DisplayOrder;

            //update the description file
            pluginDescriptor.Save();

            //raise event
            await _eventPublisher.PublishAsync(new PluginUpdatedEvent(pluginDescriptor));

            return new NullJsonResult();
        }

        #endregion
    }
}