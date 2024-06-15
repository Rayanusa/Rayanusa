using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ryn.Core;
using Ryn.Core.Domain.Customers;
using Ryn.Core.Domain.Tax;
using Ryn.Services.Common;
using Ryn.Services.Configuration;
using Ryn.Services.Security;
using Ryn.Services.Tax;
using Ryn.Web.Areas.Admin.Factories;
using Ryn.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Ryn.Web.Areas.Admin.Models.Tax;
using Ryn.Web.Framework.Mvc;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Controllers
{
    public partial class TaxController : BaseAdminController
    {
        #region Fields

        private readonly IPermissionService _permissionService;
        private readonly ISettingService _settingService;
        private readonly ITaxCategoryService _taxCategoryService;
        private readonly IGenericAttributeService _genericAttributeService;
        private readonly IWorkContext _workContext;
        private readonly ITaxModelFactory _taxModelFactory;
        private readonly ITaxPluginManager _taxPluginManager;
        private readonly TaxSettings _taxSettings;

        #endregion

        #region Ctor

        public TaxController(IPermissionService permissionService,
            ISettingService settingService,
            ITaxCategoryService taxCategoryService,
            IGenericAttributeService genericAttributeService,
            IWorkContext workContext,
            ITaxModelFactory taxModelFactory,
            ITaxPluginManager taxPluginManager,
            TaxSettings taxSettings)
        {
            _permissionService = permissionService;
            _settingService = settingService;
            _taxCategoryService = taxCategoryService;
            _genericAttributeService = genericAttributeService;
            _workContext = workContext;
            _taxModelFactory = taxModelFactory;
            _taxPluginManager = taxPluginManager;
            _taxSettings = taxSettings;
        }

        #endregion

        #region Methods

        #region Tax Providers

        public virtual IActionResult List()
        {
            return RedirectToAction("Providers");
        }

        public virtual async Task<IActionResult> Providers(bool showtour = false)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            //prepare model
            var model = await _taxModelFactory.PrepareTaxProviderSearchModelAsync(new TaxProviderSearchModel());

            //show configuration tour
            if (showtour)
            {
                var customer = await _workContext.GetCurrentCustomerAsync();
                var hideCard = await _genericAttributeService.GetAttributeAsync<bool>(customer, RynCustomerDefaults.HideConfigurationStepsAttribute);
                var closeCard = await _genericAttributeService.GetAttributeAsync<bool>(customer, RynCustomerDefaults.CloseConfigurationStepsAttribute);

                if (!hideCard && !closeCard)
                    ViewBag.ShowTour = true;
            }

            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Providers(TaxProviderSearchModel searchModel)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTaxSettings))
                return await AccessDeniedDataTablesJson();

            //prepare model
            var model = await _taxModelFactory.PrepareTaxProviderListModelAsync(searchModel);

            return Json(model);
        }

        public virtual async Task<IActionResult> MarkAsPrimaryProvider(string systemName)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            if (string.IsNullOrEmpty(systemName))
                return RedirectToAction("Providers");

            var taxProvider = await _taxPluginManager.LoadPluginBySystemNameAsync(systemName);
            if (taxProvider == null)
                return RedirectToAction("Providers");

            _taxSettings.ActiveTaxProviderSystemName = systemName;
            await _settingService.SaveSettingAsync(_taxSettings);

            return RedirectToAction("Providers");
        }

        #endregion

        #region Tax Categories

        public virtual async Task<IActionResult> Categories()
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            //prepare model
            var model = await _taxModelFactory.PrepareTaxCategorySearchModelAsync(new TaxCategorySearchModel());

            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Categories(TaxCategorySearchModel searchModel)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTaxSettings))
                return await AccessDeniedDataTablesJson();

            //prepare model
            var model = await _taxModelFactory.PrepareTaxCategoryListModelAsync(searchModel);

            return Json(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> CategoryUpdate(TaxCategoryModel model)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            if (!ModelState.IsValid)
                return ErrorJson(ModelState.SerializeErrors());

            var taxCategory = await _taxCategoryService.GetTaxCategoryByIdAsync(model.Id);
            taxCategory = model.ToEntity(taxCategory);
            await _taxCategoryService.UpdateTaxCategoryAsync(taxCategory);

            return new NullJsonResult();
        }

        [HttpPost]
        public virtual async Task<IActionResult> CategoryAdd(TaxCategoryModel model)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            if (!ModelState.IsValid)
                return ErrorJson(ModelState.SerializeErrors());

            var taxCategory = new TaxCategory();
            taxCategory = model.ToEntity(taxCategory);
            await _taxCategoryService.InsertTaxCategoryAsync(taxCategory);

            return Json(new { Result = true });
        }

        [HttpPost]
        public virtual async Task<IActionResult> CategoryDelete(int id)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageTaxSettings))
                return AccessDeniedView();

            //try to get a tax category with the specified id
            var taxCategory = await _taxCategoryService.GetTaxCategoryByIdAsync(id)
                ?? throw new ArgumentException("No tax category found with the specified id", nameof(id));

            await _taxCategoryService.DeleteTaxCategoryAsync(taxCategory);

            return new NullJsonResult();
        }

        #endregion

        #endregion
    }
}