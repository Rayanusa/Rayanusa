using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Messages
{
    /// <summary>
    /// Represents a queued email list model
    /// </summary>
    public partial record QueuedEmailListModel : BasePagedListModel<QueuedEmailModel>
    {
    }
}