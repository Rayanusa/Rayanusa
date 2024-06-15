using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an incomplete order report model
    /// </summary>
    public partial record OrderIncompleteReportModel : BaseRynModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.SalesReport.Incomplete.Item")]
        public string Item { get; set; }

        [RynResourceDisplayName("Admin.SalesReport.Incomplete.Total")]
        public string Total { get; set; }

        [RynResourceDisplayName("Admin.SalesReport.Incomplete.Count")]
        public int Count { get; set; }

        [RynResourceDisplayName("Admin.SalesReport.Incomplete.View")]
        public string ViewLink { get; set; }

        #endregion
    }
}