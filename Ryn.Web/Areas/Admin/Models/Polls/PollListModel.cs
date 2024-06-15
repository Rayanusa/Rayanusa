using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Polls
{
    /// <summary>
    /// Represents a poll list model
    /// </summary>
    public partial record PollListModel : BasePagedListModel<PollModel>
    {
    }
}