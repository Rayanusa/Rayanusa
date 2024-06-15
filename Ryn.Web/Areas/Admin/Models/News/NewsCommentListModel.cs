using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.News
{
    /// <summary>
    /// Represents a news comment list model
    /// </summary>
    public partial record NewsCommentListModel : BasePagedListModel<NewsCommentModel>
    {
    }
}