using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product tag search model
    /// </summary>
    public partial record ProductTagSearchModel : BaseSearchModel
    {
        [RynResourceDisplayName("Admin.Catalog.ProductTags.Fields.SearchTagName")]
        public string SearchTagName { get; set; }
    }
}