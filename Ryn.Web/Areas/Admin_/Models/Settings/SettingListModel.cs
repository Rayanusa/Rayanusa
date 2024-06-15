using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a setting list model
    /// </summary>
    public partial record SettingListModel : BasePagedListModel<SettingModel>
    {
    }
}