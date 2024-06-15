using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor list model
    /// </summary>
    public partial record VendorListModel : BasePagedListModel<VendorModel>
    {
    }
}