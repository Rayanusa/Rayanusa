using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a hosting configuration model
    /// </summary>
    public partial record HostingConfigModel : BaseRynModel, IConfigModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Hosting.UseProxy")]
        public bool UseProxy { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Hosting.ForwardedForHeaderName")]
        public string ForwardedForHeaderName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Hosting.ForwardedProtoHeaderName")]
        public string ForwardedProtoHeaderName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Hosting.KnownProxies")]
        public string KnownProxies { get; set; }

        #endregion
    }
}