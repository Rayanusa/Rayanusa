using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer attribute value list model
    /// </summary>
    public partial record CustomerAttributeValueListModel : BasePagedListModel<CustomerAttributeValueModel>
    {
    }
}