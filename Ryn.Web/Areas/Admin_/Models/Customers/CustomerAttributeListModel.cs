using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer attribute list model
    /// </summary>
    public partial record CustomerAttributeListModel : BasePagedListModel<CustomerAttributeModel>
    {
    }
}