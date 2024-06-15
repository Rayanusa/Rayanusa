using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a shipment item list model
    /// </summary>
    public partial record ShipmentItemListModel : BasePagedListModel<ShipmentItemModel>
    {
    }
}