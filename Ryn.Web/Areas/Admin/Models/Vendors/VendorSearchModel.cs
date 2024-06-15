using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor search model
    /// </summary>
    public partial record VendorSearchModel : BaseSearchModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Vendors.List.SearchName")]
        public string SearchName { get; set; }

        [RynResourceDisplayName("Admin.Vendors.List.SearchEmail")]
        public string SearchEmail { get; set; }

        #endregion
    }
}