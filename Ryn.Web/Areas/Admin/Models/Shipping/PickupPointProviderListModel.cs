using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a pickup point provider list model
    /// </summary>
    public partial record PickupPointProviderListModel : BasePagedListModel<PickupPointProviderModel>
    {
    }
}