using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a product availability range list model
    /// </summary>
    public partial record ProductAvailabilityRangeListModel : BasePagedListModel<ProductAvailabilityRangeModel>
    {
    }
}