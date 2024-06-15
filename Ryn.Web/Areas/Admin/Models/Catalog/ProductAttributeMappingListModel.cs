using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product attribute mapping list model
    /// </summary>
    public partial record ProductAttributeMappingListModel : BasePagedListModel<ProductAttributeMappingModel>
    {
    }
}