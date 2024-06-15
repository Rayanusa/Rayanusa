using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product review list model
    /// </summary>
    public partial record ProductReviewListModel : BasePagedListModel<ProductReviewModel>
    {
    }
}