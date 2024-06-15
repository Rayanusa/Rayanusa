using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product review and review type mapping model
    /// </summary>
    public record ProductReviewReviewTypeMappingModel : BaseRynEntityModel
    {
        #region Properties

        public int ProductReviewId { get; set; }

        [RynResourceDisplayName("Admin.Catalog.ProductReviewsExt.Fields.Name")]
        public string Name { get; set; }

        [RynResourceDisplayName("Admin.Catalog.ProductReviewsExt.Fields.Description")]
        public string Description { get; set; }

        [RynResourceDisplayName("Admin.Catalog.ProductReviewsExt.Fields.VisibleToAllCustomers")]
        public bool VisibleToAllCustomers { get; set; }

        [RynResourceDisplayName("Admin.Catalog.ProductReviewsExt.Fields.Rating")]
        public int Rating { get; set; }

        #endregion
    }
}
