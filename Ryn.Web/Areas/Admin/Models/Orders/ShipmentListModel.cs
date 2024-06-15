using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a shipment list model
    /// </summary>
    public partial record ShipmentListModel : BasePagedListModel<ShipmentModel>
    {
    }
}