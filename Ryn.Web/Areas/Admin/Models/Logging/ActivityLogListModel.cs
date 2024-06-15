using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Logging
{
    /// <summary>
    /// Represents an activity log list model
    /// </summary>
    public partial record ActivityLogListModel : BasePagedListModel<ActivityLogModel>
    {
    }
}