using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an order list model
    /// </summary>
    public partial record OrderListModel : BasePagedListModel<OrderModel>
    {
    }
}