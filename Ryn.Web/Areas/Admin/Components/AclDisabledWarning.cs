﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ryn.Core.Domain.Catalog;
using Ryn.Services.Configuration;
using Ryn.Services.Stores;
using Ryn.Web.Framework.Components;

namespace Ryn.Web.Areas.Admin.Components
{
    public class AclDisabledWarningViewComponent : RynViewComponent
    {
        private readonly CatalogSettings _catalogSettings;
        private readonly ISettingService _settingService;
        private readonly IStoreService _storeService;

        public AclDisabledWarningViewComponent(CatalogSettings catalogSettings,
            ISettingService settingService,
            IStoreService storeService)
        {
            _catalogSettings = catalogSettings;
            _settingService = settingService;
            _storeService = storeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //action displaying notification (warning) to a store owner that "ACL rules" feature is ignored

            //default setting
            var enabled = _catalogSettings.IgnoreAcl;
            if (!enabled)
            {
                //overridden settings
                var stores = await _storeService.GetAllStoresAsync();
                foreach (var store in stores)
                {
                    var catalogSettings = await _settingService.LoadSettingAsync<CatalogSettings>(store.Id);
                    enabled = catalogSettings.IgnoreAcl;

                    if (enabled)
                        break;
                }
            }

            //This setting is disabled. No warnings.
            if (!enabled)
                return Content(string.Empty);

            return View();
        }
    }
}
