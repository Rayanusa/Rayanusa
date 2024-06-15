using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an order shipment list model
    /// </summary>
    public partial record OrderShipmentListModel : BasePagedListModel<ShipmentModel>
    {
    }
}