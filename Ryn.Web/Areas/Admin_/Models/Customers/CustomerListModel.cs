using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer list model
    /// </summary>
    public partial record CustomerListModel : BasePagedListModel<CustomerModel>
    {
    }
}