using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents a popular search term model
    /// </summary>
    public partial record PopularSearchTermModel : BaseRynModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.SearchTermReport.Keyword")]
        public string Keyword { get; set; }

        [RynResourceDisplayName("Admin.SearchTermReport.Count")]
        public int Count { get; set; }

        #endregion
    }
}
