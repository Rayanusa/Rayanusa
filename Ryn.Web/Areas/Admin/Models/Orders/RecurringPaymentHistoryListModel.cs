using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a recurring payment history list model
    /// </summary>
    public partial record RecurringPaymentHistoryListModel : BasePagedListModel<RecurringPaymentHistoryModel>
    {
    }
}