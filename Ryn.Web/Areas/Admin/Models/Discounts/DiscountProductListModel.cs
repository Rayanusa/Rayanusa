using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount product list model
    /// </summary>
    public partial record DiscountProductListModel : BasePagedListModel<DiscountProductModel>
    {
    }
}