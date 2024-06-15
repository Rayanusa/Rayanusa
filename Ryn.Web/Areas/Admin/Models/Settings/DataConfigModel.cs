using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    public partial record DataConfigModel : BaseRynModel, IConfigModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Data.ConnectionString")]
        public string ConnectionString { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Data.DataProvider")]
        public int DataProvider { get; set; }
        public SelectList DataProviderTypeValues { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Data.SQLCommandTimeout")]
        [UIHint("Int32Nullable")]
        public int? SQLCommandTimeout { get; set; }

        #endregion
    }
}
