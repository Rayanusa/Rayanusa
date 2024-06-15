using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.MultiFactorAuthentication
{
    /// <summary>
    /// Represents an multi-factor authentication method model
    /// </summary>
    public partial record MultiFactorAuthenticationMethodModel : BaseRynModel, IPluginModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.Authentication.MultiFactorMethods.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Authentication.MultiFactorMethods.Fields.SystemName")]
        public string SystemName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Authentication.MultiFactorMethods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Authentication.MultiFactorMethods.Fields.IsActive")]
        public bool IsActive { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Authentication.MultiFactorMethods.Configure")]
        public string ConfigurationUrl { get; set; }

        public string LogoUrl { get; set; }

        #endregion
    }
}
