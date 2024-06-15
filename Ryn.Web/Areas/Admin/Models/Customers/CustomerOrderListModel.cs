using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer order list model
    /// </summary>
    public partial record CustomerOrderListModel : BasePagedListModel<CustomerOrderModel>
    {
    }
}