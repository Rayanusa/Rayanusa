using System;
using System.Collections.Generic;
using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    public partial record SystemInfoModel : BaseRynModel
    {
        public SystemInfoModel()
        {
            Headers = new List<HeaderModel>();
            LoadedAssemblies = new List<LoadedAssembly>();
        }

        [RynResourceDisplayName("Admin.System.SystemInfo.ASPNETInfo")]
        public string AspNetInfo { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.IsFullTrust")]
        public bool IsFullTrust { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.RynVersion")]
        public string RynVersion { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.OperatingSystem")]
        public string OperatingSystem { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.ServerLocalTime")]
        public DateTime ServerLocalTime { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.ServerTimeZone")]
        public string ServerTimeZone { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.UTCTime")]
        public DateTime UtcTime { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.CurrentUserTime")]
        public DateTime CurrentUserTime { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.CurrentStaticCacheManager")]
        public string CurrentStaticCacheManager { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.HTTPHOST")]
        public string HttpHost { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.Headers")]
        public IList<HeaderModel> Headers { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.LoadedAssemblies")]
        public IList<LoadedAssembly> LoadedAssemblies { get; set; }

        [RynResourceDisplayName("Admin.System.SystemInfo.AzureBlobStorageEnabled")]
        public bool AzureBlobStorageEnabled { get; set; }

        public partial record HeaderModel : BaseRynModel
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public partial record LoadedAssembly : BaseRynModel
        {
            public string FullName { get; set; }
            public string Location { get; set; }
            public bool IsDebug { get; set; }
            public DateTime? BuildDate { get; set; }
        }
    }
}