using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a never sold products report list model
    /// </summary>
    public partial record NeverSoldReportListModel : BasePagedListModel<NeverSoldReportModel>
    {
    }
}