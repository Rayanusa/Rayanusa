using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a checkout attribute list model
    /// </summary>
    public record CheckoutAttributeListModel : BasePagedListModel<CheckoutAttributeModel>
    {
    }
}