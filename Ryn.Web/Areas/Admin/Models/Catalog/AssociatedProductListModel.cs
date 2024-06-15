using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents an associated product list model
    /// </summary>
    public partial record AssociatedProductListModel : BasePagedListModel<AssociatedProductModel>
    {
    }
}