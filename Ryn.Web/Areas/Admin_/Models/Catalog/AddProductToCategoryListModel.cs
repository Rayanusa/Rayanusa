using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product list model to add to the category
    /// </summary>
    public partial record AddProductToCategoryListModel : BasePagedListModel<ProductModel>
    {
    }
}