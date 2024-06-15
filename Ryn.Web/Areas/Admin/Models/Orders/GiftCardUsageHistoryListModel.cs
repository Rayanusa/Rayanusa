using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a gift card usage history list model
    /// </summary>
    public record GiftCardUsageHistoryListModel : BasePagedListModel<GiftCardUsageHistoryModel>
    {
    }
}