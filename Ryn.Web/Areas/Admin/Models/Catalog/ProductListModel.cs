using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product list model
    /// </summary>
    public partial record ProductListModel : BasePagedListModel<ProductModel>
    {
    }
}