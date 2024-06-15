using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a cache configuration model
    /// </summary>
    public partial record CacheConfigModel : BaseRynModel, IConfigModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Cache.DefaultCacheTime")]
        public int DefaultCacheTime { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Cache.ShortTermCacheTime")]
        public int ShortTermCacheTime { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Cache.BundledFilesCacheTime")]
        public int BundledFilesCacheTime { get; set; }

        #endregion
    }
}