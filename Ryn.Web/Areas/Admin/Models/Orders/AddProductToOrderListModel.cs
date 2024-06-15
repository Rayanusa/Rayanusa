using Ryn.Web.Areas.Admin.Models.Catalog;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a product list model to add to the order
    /// </summary>
    public partial record AddProductToOrderListModel : BasePagedListModel<ProductModel>
    {
    }
}