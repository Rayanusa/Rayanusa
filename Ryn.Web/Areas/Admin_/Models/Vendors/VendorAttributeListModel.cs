using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor attribute list model
    /// </summary>
    public partial record VendorAttributeListModel : BasePagedListModel<VendorAttributeModel>
    {
    }
}