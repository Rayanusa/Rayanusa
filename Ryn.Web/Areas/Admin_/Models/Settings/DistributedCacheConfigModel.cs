using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents distributed cache configuration model
    /// </summary>
    public partial record DistributedCacheConfigModel : BaseRynModel, IConfigModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.AppSettings.DistributedCache.DistributedCacheType")]
        public SelectList DistributedCacheTypeValues { get; set; }
        public int DistributedCacheType { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.DistributedCache.Enabled")]
        public bool Enabled { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.DistributedCache.ConnectionString")]
        public string ConnectionString { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.DistributedCache.SchemaName")]
        public string SchemaName { get; set; } = "dbo";

        [RynResourceDisplayName("Admin.Configuration.AppSettings.DistributedCache.TableName")]
        public string TableName { get; set; } = "DistributedCache";

        #endregion
    }
}