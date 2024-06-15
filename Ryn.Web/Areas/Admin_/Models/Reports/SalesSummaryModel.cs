using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a sales summary model
    /// </summary>
    public partial record SalesSummaryModel : BaseRynModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Fields.Summary")]
        public string Summary { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Fields.NumberOfOrders")]
        public int NumberOfOrders { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Fields.Profit")]
        public string ProfitStr { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Fields.Shipping")]
        public string Shipping { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Fields.Tax")]
        public string Tax { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Fields.OrderTotal")]
        public string OrderTotal { get; set; }

        #endregion
    }
}
