using Ryn.Web.Areas.Admin.Models.Orders;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product order list model
    /// </summary>
    public partial record ProductOrderListModel : BasePagedListModel<OrderModel>
    {
    }
}