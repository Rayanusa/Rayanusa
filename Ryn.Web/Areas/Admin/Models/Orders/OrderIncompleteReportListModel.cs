using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an incomplete order report list model
    /// </summary>
    public partial record OrderIncompleteReportListModel : BasePagedListModel<OrderIncompleteReportModel>
    {
    }
}