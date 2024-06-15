using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Tax
{
    /// <summary>
    /// Represents a tax provider list model
    /// </summary>
    public partial record TaxProviderListModel : BasePagedListModel<TaxProviderModel>
    {
    }
}