using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a gift card list model
    /// </summary>
    public record GiftCardListModel : BasePagedListModel<GiftCardModel>
    {
    }
}