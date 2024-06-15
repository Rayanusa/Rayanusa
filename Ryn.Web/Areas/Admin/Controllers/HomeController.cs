using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ryn.Core;
using Ryn.Core.Domain.Common;
using Ryn.Core.Domain.Customers;
using Ryn.Services.Common;
using Ryn.Services.Configuration;
using Ryn.Services.Localization;
using Ryn.Services.Messages;
using Ryn.Services.Security;
using Ryn.Web.Areas.Admin.Factories;
using Ryn.Web.Areas.Admin.Models.Common;
using Ryn.Web.Areas.Admin.Models.Home;

namespace Ryn.Web.Areas.Admin.Controllers
{
    public partial class HomeController : BaseAdminController
    {
        #region Fields

        private readonly AdminAreaSettings _adminAreaSettings;
        private readonly ICommonModelFactory _commonModelFactory;
        private readonly IHomeModelFactory _homeModelFactory;
        private readonly ILocalizationService _localizationService;
        private readonly INotificationService _notificationService;
        private readonly IPermissionService _permissionService;
        private readonly ISettingService _settingService;
        private readonly IGenericAttributeService _genericAttributeService;
        private readonly IWorkContext _workContext;

        #endregion

        #region Ctor

        public HomeController(AdminAreaSettings adminAreaSettings,
            ICommonModelFactory commonModelFactory,
            IHomeModelFactory homeModelFactory,
            ILocalizationService localizationService,
            INotificationService notificationService,
            IPermissionService permissionService,
            ISettingService settingService,
            IGenericAttributeService genericAttributeService,
            IWorkContext workContext)
        {
            _adminAreaSettings = adminAreaSettings;
            _commonModelFactory = commonModelFactory;
            _homeModelFactory = homeModelFactory;
            _localizationService = localizationService;
            _notificationService = notificationService;
            _permissionService = permissionService;
            _settingService = settingService;
            _workContext = workContext;
            _genericAttributeService = genericAttributeService;
        }

        #endregion

        #region Methods

        public virtual async Task<IActionResult> Index()
        {
            //display a warning to a store owner if there are some error
            var customer = await _workContext.GetCurrentCustomerAsync();
            var hideCard = await _genericAttributeService.GetAttributeAsync<bool>(customer, RynCustomerDefaults.HideConfigurationStepsAttribute);
            var closeCard = await _genericAttributeService.GetAttributeAsync<bool>(customer, RynCustomerDefaults.CloseConfigurationStepsAttribute);

            if ((hideCard || closeCard) && await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageMaintenance))
            {
                var warnings = await _commonModelFactory.PrepareSystemWarningModelsAsync();
                if (warnings.Any(warning => warning.Level == SystemWarningLevel.Fail ||
                                            warning.Level == SystemWarningLevel.CopyrightRemovalKey ||
                                            warning.Level == SystemWarningLevel.Warning))
                    _notificationService.WarningNotification(
                        string.Format(await _localizationService.GetResourceAsync("Admin.System.Warnings.Errors"),
                        Url.Action("Warnings", "Common")),
                        //do not encode URLs
                        false);
            }

            //progress of localozation 
            var currentLanguage = await _workContext.GetWorkingLanguageAsync();
            var progress = await _genericAttributeService.GetAttributeAsync<string>(currentLanguage, RynCommonDefaults.LanguagePackProgressAttribute);
            if (!string.IsNullOrEmpty(progress))
            {
                var locale = await _localizationService.GetResourceAsync("Admin.Configuration.LanguagePackProgressMessage");
                _notificationService.SuccessNotification(string.Format(locale, progress, RynLinksDefaults.OfficialSite.Translations), false);
                await _genericAttributeService.SaveAttributeAsync(currentLanguage, RynCommonDefaults.LanguagePackProgressAttribute, string.Empty);
            }

            //prepare model
            var model = await _homeModelFactory.PrepareDashboardModelAsync(new DashboardModel());

            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> RynCommerceNewsHideAdv()
        {
            _adminAreaSettings.HideAdvertisementsOnAdminArea = !_adminAreaSettings.HideAdvertisementsOnAdminArea;
            await _settingService.SaveSettingAsync(_adminAreaSettings);

            return Content("Setting changed");
        }

        #endregion
    }
}