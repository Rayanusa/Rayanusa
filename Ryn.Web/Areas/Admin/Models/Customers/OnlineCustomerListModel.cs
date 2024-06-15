using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents an online customer list model
    /// </summary>
    public partial record OnlineCustomerListModel : BasePagedListModel<OnlineCustomerModel>
    {
    }
}