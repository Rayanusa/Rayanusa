using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a tier price list model
    /// </summary>
    public partial record TierPriceListModel : BasePagedListModel<TierPriceModel>
    {
    }
}