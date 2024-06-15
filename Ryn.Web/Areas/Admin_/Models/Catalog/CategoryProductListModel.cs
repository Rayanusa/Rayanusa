using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a category product list model
    /// </summary>
    public partial record CategoryProductListModel : BasePagedListModel<CategoryProductModel>
    {
    }
}