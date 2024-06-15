using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product specification attribute list model
    /// </summary>
    public partial record ProductSpecificationAttributeListModel : BasePagedListModel<ProductSpecificationAttributeModel>
    {
    }
}