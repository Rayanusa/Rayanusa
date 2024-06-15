using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a sales summary list model
    /// </summary>
    public partial record SalesSummaryListModel : BasePagedListModel<SalesSummaryModel>
    {
    }
}
