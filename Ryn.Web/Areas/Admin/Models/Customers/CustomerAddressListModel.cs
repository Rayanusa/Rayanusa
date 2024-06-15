using Ryn.Web.Areas.Admin.Models.Common;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer address list model
    /// </summary>
    public partial record CustomerAddressListModel : BasePagedListModel<AddressModel>
    {
    }
}