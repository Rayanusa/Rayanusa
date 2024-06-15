using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a related product list model
    /// </summary>
    public partial record RelatedProductListModel : BasePagedListModel<RelatedProductModel>
    {
    }
}