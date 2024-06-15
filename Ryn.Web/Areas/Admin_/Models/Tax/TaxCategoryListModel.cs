using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Tax
{
    /// <summary>
    /// Represents a tax category list model
    /// </summary>
    public partial record TaxCategoryListModel : BasePagedListModel<TaxCategoryModel>
    {
    }
}