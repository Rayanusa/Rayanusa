using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount list model
    /// </summary>
    public partial record DiscountListModel : BasePagedListModel<DiscountModel>
    {
    }
}