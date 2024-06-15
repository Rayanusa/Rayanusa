using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents WebOptimizer config model
    /// </summary>
    public partial record WebOptimizerConfigModel : BaseRynModel, IConfigModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.AppSettings.WebOptimizer.EnableJavaScriptBundling")]
        public bool EnableJavaScriptBundling { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.WebOptimizer.EnableCssBundling")]
        public bool EnableCssBundling { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.WebOptimizer.EnableDiskCache")]
        public bool EnableDiskCache { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.WebOptimizer.CacheDirectory")]
        public string CacheDirectory { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.WebOptimizer.JavaScriptBundleSuffix")]
        public string JavaScriptBundleSuffix { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.WebOptimizer.CssBundleSuffix")]
        public string CssBundleSuffix { get; set; }

        #endregion
    }
}
