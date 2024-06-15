using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents an installation configuration model
    /// </summary>
    public partial record InstallationConfigModel : BaseRynModel, IConfigModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Installation.DisableSampleData")]
        public bool DisableSampleData { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Installation.DisabledPlugins")]
        public string DisabledPlugins { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Installation.InstallRegionalResources")]
        public bool InstallRegionalResources { get; set; }

        #endregion
    }
}