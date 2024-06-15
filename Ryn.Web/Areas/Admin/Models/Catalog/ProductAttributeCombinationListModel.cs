using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product attribute combination list model
    /// </summary>
    public partial record ProductAttributeCombinationListModel : BasePagedListModel<ProductAttributeCombinationModel>
    {
    }
}