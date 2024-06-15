using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Polls
{
    /// <summary>
    /// Represents a poll answer list model
    /// </summary>
    public partial record PollAnswerListModel : BasePagedListModel<PollAnswerModel>
    {
    }
}