using Ryn.Services.Orders;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a bestseller brief search model
    /// </summary>
    public partial record BestsellerBriefSearchModel : BaseSearchModel
    {
        #region Properties

        public OrderByEnum OrderBy { get; set; }

        #endregion
    }
}