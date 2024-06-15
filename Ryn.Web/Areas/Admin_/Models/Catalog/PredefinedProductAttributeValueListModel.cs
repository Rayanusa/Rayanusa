using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a predefined product attribute value list model
    /// </summary>
    public partial record PredefinedProductAttributeValueListModel : BasePagedListModel<PredefinedProductAttributeValueModel>
    {
    }
}