using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Affiliates
{
    /// <summary>
    /// Represents an affiliated customer list model
    /// </summary>
    public partial record AffiliatedCustomerListModel : BasePagedListModel<AffiliatedCustomerModel>
    {
    }
}