using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount category list model
    /// </summary>
    public partial record DiscountCategoryListModel : BasePagedListModel<DiscountCategoryModel>
    {
    }
}