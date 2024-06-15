using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Plugins
{
    /// <summary>
    /// Represents a plugin list model
    /// </summary>
    public partial record PluginListModel : BasePagedListModel<PluginModel>
    {
    }
}