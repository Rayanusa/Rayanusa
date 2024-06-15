using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Forums
{
    /// <summary>
    /// Represents a forum list model
    /// </summary>
    public partial record ForumListModel : BasePagedListModel<ForumModel>
    {
    }
}