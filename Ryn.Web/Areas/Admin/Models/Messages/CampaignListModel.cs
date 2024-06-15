using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Messages
{
    /// <summary>
    /// Represents a campaign list model
    /// </summary>
    public partial record CampaignListModel : BasePagedListModel<CampaignModel>
    {
    }
}