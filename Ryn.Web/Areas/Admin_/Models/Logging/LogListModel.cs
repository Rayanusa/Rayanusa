using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Logging
{
    /// <summary>
    /// Represents a log list model
    /// </summary>
    public partial record LogListModel : BasePagedListModel<LogModel>
    {
    }
}