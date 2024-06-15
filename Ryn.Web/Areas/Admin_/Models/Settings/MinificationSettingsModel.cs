using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a minification settings model
    /// </summary>
    public partial record MinificationSettingsModel : BaseRynModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.EnableHtmlMinification")]
        public bool EnableHtmlMinification { get; set; }
        public bool EnableHtmlMinification_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.UseResponseCompression")]
        public bool UseResponseCompression { get; set; }
        public bool UseResponseCompression_OverrideForStore { get; set; }

        #endregion

    }
}
