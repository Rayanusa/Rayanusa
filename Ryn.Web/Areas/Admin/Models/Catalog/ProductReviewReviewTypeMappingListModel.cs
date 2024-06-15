using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product review and review type mapping list model
    /// </summary>
    public partial record ProductReviewReviewTypeMappingListModel : BasePagedListModel<ProductReviewReviewTypeMappingModel>
    {
    }
}
