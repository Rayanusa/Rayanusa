using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a model of products that use the specification attribute
    /// </summary>
    public partial record SpecificationAttributeProductModel : BaseRynEntityModel
    {
        #region Properties

        public int SpecificationAttributeId { get; set; }

        public int ProductId { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttribute.UsedByProducts.Product")]
        public string ProductName { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttribute.UsedByProducts.Published")]
        public bool Published { get; set; }

        #endregion
    }
}