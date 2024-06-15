using System.ComponentModel.DataAnnotations;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a common configuration model
    /// </summary>
    public partial record CommonConfigModel : BaseRynModel, IConfigModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.DisplayFullErrorStack")]
        public bool DisplayFullErrorStack { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.UserAgentStringsPath")]
        public string UserAgentStringsPath { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.CrawlerOnlyUserAgentStringsPath")]
        public string CrawlerOnlyUserAgentStringsPath { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.UseSessionStateTempDataProvider")]
        public bool UseSessionStateTempDataProvider { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.MiniProfilerEnabled")]
        public bool MiniProfilerEnabled { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.ScheduleTaskRunTimeout")]
        [UIHint("Int32Nullable")]
        public int? ScheduleTaskRunTimeout { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.StaticFilesCacheControl")]
        public string StaticFilesCacheControl { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.SupportPreviousrynCommerceVersions")]
        public bool SupportPreviousrynCommerceVersions { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.PluginStaticFileExtensionsBlacklist")]
        public string PluginStaticFileExtensionsBlacklist { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Common.ServeUnknownFileTypes")]
        public bool ServeUnknownFileTypes { get; set; }

        #endregion
    }
}