using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a cross-sell product list model
    /// </summary>
    public partial record CrossSellProductListModel : BasePagedListModel<CrossSellProductModel>
    {
    }
}