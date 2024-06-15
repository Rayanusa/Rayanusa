using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a checkout attribute value list model
    /// </summary>
    public record CheckoutAttributeValueListModel : BasePagedListModel<CheckoutAttributeValueModel>
    {
    }
}