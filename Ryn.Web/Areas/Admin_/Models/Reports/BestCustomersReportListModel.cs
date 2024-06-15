using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a best customers report list model
    /// </summary>
    public partial record BestCustomersReportListModel : BasePagedListModel<BestCustomersReportModel>
    {
    }
}