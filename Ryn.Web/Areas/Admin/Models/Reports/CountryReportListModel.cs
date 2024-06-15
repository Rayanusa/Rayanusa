using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a country report list model
    /// </summary>
    public partial record CountryReportListModel : BasePagedListModel<CountryReportModel>
    {
    }
}