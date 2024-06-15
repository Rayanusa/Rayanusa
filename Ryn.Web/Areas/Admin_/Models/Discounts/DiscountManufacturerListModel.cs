using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount manufacturer list model
    /// </summary>
    public partial record DiscountManufacturerListModel : BasePagedListModel<DiscountManufacturerModel>
    {
    }
}