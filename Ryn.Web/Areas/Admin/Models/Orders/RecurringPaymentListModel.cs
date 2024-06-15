using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a recurring payment list model
    /// </summary>
    public partial record RecurringPaymentListModel : BasePagedListModel<RecurringPaymentModel>
    {
    }
}