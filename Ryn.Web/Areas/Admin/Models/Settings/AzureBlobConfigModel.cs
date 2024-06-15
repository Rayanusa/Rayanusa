using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents Azure Blob storage configuration model
    /// </summary>
    public partial record AzureBlobConfigModel : BaseRynModel, IConfigModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.AppSettings.AzureBlob.ConnectionString")]
        public string ConnectionString { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.AzureBlob.ContainerName")]
        public string ContainerName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.AzureBlob.EndPoint")]
        public string EndPoint { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.AzureBlob.AppendContainerName")]
        public bool AppendContainerName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.AzureBlob.StoreDataProtectionKeys")]
        public bool StoreDataProtectionKeys { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.AzureBlob.DataProtectionKeysContainerName")]
        public string DataProtectionKeysContainerName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.AzureBlob.DataProtectionKeysVaultId")]
        public string DataProtectionKeysVaultId { get; set; }

        #endregion
    }
}