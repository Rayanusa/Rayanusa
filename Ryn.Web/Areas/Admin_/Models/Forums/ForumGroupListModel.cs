using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Forums
{
    /// <summary>
    /// Represents a forum group list model
    /// </summary>
    public partial record ForumGroupListModel : BasePagedListModel<ForumGroupModel>
    {
    }
}