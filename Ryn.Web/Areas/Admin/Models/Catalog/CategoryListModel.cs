using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a category list model
    /// </summary>
    public partial record CategoryListModel : BasePagedListModel<CategoryModel>
    {
    }
}