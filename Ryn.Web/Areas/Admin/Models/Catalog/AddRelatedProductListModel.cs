using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a related product list model to add to the product
    /// </summary>
    public partial record AddRelatedProductListModel : BasePagedListModel<ProductModel>
    {
    }
}