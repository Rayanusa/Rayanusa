using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an an order average report line summary list model
    /// </summary>
    public partial record OrderAverageReportListModel : BasePagedListModel<OrderAverageReportModel>
    {
    }
}