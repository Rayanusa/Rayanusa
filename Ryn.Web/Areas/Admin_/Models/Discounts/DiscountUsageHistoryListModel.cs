using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount usage history list model
    /// </summary>
    public partial record DiscountUsageHistoryListModel : BasePagedListModel<DiscountUsageHistoryModel>
    {
    }
}