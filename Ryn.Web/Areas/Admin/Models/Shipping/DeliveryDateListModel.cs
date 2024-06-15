using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a delivery date list model
    /// </summary>
    public partial record DeliveryDateListModel : BasePagedListModel<DeliveryDateModel>
    {
    }
}