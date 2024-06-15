using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product attribute value list model
    /// </summary>
    public partial record ProductAttributeValueListModel : BasePagedListModel<ProductAttributeValueModel>
    {
    }
}