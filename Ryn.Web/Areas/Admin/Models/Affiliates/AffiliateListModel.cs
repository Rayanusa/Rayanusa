using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Affiliates
{
    /// <summary>
    /// Represents an affiliate list model
    /// </summary>
    public partial record AffiliateListModel : BasePagedListModel<AffiliateModel>
    {
    }
}