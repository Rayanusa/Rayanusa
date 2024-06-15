using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Plugins.Marketplace
{
    /// <summary>
    /// Represents a list model of plugins of the official feed
    /// </summary>
    public partial record OfficialFeedPluginListModel : BasePagedListModel<OfficialFeedPluginModel>
    {
    }
}