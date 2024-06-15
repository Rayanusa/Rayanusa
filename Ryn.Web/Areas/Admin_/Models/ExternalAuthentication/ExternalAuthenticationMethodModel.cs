using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.ExternalAuthentication
{
    /// <summary>
    /// Represents an external authentication method model
    /// </summary>
    public partial record ExternalAuthenticationMethodModel : BaseRynModel, IPluginModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.Authentication.ExternalMethods.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Authentication.ExternalMethods.Fields.SystemName")]
        public string SystemName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Authentication.ExternalMethods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Authentication.ExternalMethods.Fields.IsActive")]
        public bool IsActive { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Authentication.ExternalMethods.Configure")]
        public string ConfigurationUrl { get; set; }

        public string LogoUrl { get; set; }

        #endregion
    }
}