using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a registered customers report list model
    /// </summary>
    public partial record RegisteredCustomersReportListModel : BasePagedListModel<RegisteredCustomersReportModel>
    {
    }
}