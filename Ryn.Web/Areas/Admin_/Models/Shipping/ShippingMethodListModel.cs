using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a shipping method list model
    /// </summary>
    public partial record ShippingMethodListModel : BasePagedListModel<ShippingMethodModel>
    {
    }
}