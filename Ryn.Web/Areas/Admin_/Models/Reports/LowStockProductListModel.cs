using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a low stock product list model
    /// </summary>
    public partial record LowStockProductListModel : BasePagedListModel<LowStockProductModel>
    {
    }
}