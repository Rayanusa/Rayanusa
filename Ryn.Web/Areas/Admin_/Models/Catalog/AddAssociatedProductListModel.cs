using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents an associated product list model to add to the product
    /// </summary>
    public partial record AddAssociatedProductListModel : BasePagedListModel<ProductModel>
    {
    }
}