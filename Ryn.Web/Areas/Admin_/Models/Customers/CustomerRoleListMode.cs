using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer role list model
    /// </summary>
    public partial record CustomerRoleListModel : BasePagedListModel<CustomerRoleModel>
    {
    }
}