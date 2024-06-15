﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ryn.Core.Domain.Customers;
using Ryn.Core.Events;
using Ryn.Services.Authentication.External;
using Ryn.Services.Configuration;
using Ryn.Services.Plugins;
using Ryn.Services.Security;
using Ryn.Web.Areas.Admin.Factories;
using Ryn.Web.Areas.Admin.Models.ExternalAuthentication;
using Ryn.Web.Framework.Mvc;

namespace Ryn.Web.Areas.Admin.Controllers
{
    public partial class ExternalAuthenticationController : BaseAdminController
    {
        #region Fields

        private readonly ExternalAuthenticationSettings _externalAuthenticationSettings;
        private readonly IAuthenticationPluginManager _authenticationPluginManager;
        private readonly IEventPublisher _eventPublisher;
        private readonly IExternalAuthenticationMethodModelFactory _externalAuthenticationMethodModelFactory;
        private readonly IPermissionService _permissionService;
        private readonly ISettingService _settingService;

        #endregion

        #region Ctor

        public ExternalAuthenticationController(ExternalAuthenticationSettings externalAuthenticationSettings,
            IAuthenticationPluginManager authenticationPluginManager,
            IEventPublisher eventPublisher,
            IExternalAuthenticationMethodModelFactory externalAuthenticationMethodModelFactory,
            IPermissionService permissionService,
            ISettingService settingService)
        {
            _externalAuthenticationSettings = externalAuthenticationSettings;
            _authenticationPluginManager = authenticationPluginManager;
            _eventPublisher = eventPublisher;
            _externalAuthenticationMethodModelFactory = externalAuthenticationMethodModelFactory;
            _permissionService = permissionService;
            _settingService = settingService;
        }

        #endregion

        #region Methods

        public virtual async Task<IActionResult> Methods()
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageExternalAuthenticationMethods))
                return AccessDeniedView();

            //prepare model
            var model = _externalAuthenticationMethodModelFactory
                .PrepareExternalAuthenticationMethodSearchModel(new ExternalAuthenticationMethodSearchModel());

            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Methods(ExternalAuthenticationMethodSearchModel searchModel)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageExternalAuthenticationMethods))
                return await AccessDeniedDataTablesJson();

            //prepare model
            var model = await _externalAuthenticationMethodModelFactory.PrepareExternalAuthenticationMethodListModelAsync(searchModel);

            return Json(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> MethodUpdate(ExternalAuthenticationMethodModel model)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageExternalAuthenticationMethods))
                return AccessDeniedView();

            var method = await _authenticationPluginManager.LoadPluginBySystemNameAsync(model.SystemName);
            if (_authenticationPluginManager.IsPluginActive(method))
            {
                if (!model.IsActive)
                {
                    //mark as disabled
                    _externalAuthenticationSettings.ActiveAuthenticationMethodSystemNames.Remove(method.PluginDescriptor.SystemName);
                    await _settingService.SaveSettingAsync(_externalAuthenticationSettings);
                }
            }
            else
            {
                if (model.IsActive)
                {
                    //mark as active
                    _externalAuthenticationSettings.ActiveAuthenticationMethodSystemNames.Add(method.PluginDescriptor.SystemName);
                    await _settingService.SaveSettingAsync(_externalAuthenticationSettings);
                }
            }

            var pluginDescriptor = method.PluginDescriptor;
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