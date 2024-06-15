using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer back in stock subscriptions list model
    /// </summary>
    public partial record CustomerBackInStockSubscriptionListModel : BasePagedListModel<CustomerBackInStockSubscriptionModel>
    {
    }
}