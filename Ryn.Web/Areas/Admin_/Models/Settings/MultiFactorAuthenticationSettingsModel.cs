using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a multi-factor authentication settings model
    /// </summary>
    public partial record MultiFactorAuthenticationSettingsModel : BaseRynModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.CustomerUser.ForceMultifactorAuthentication")]
        public bool ForceMultifactorAuthentication { get; set; }

        #endregion
    }
}
