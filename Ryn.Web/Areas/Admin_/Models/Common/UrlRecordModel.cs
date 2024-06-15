using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents an URL record model
    /// </summary>
    public partial record UrlRecordModel : BaseRynEntityModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.System.SeNames.Name")]
        public string Name { get; set; }

        [RynResourceDisplayName("Admin.System.SeNames.EntityId")]
        public int EntityId { get; set; }

        [RynResourceDisplayName("Admin.System.SeNames.EntityName")]
        public string EntityName { get; set; }

        [RynResourceDisplayName("Admin.System.SeNames.IsActive")]
        public bool IsActive { get; set; }

        [RynResourceDisplayName("Admin.System.SeNames.Language")]
        public string Language { get; set; }

        [RynResourceDisplayName("Admin.System.SeNames.Details")]
        public string DetailsUrl { get; set; }

        #endregion
    }
}