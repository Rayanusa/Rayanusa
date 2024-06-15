using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Blogs
{
    /// <summary>
    /// Represents a blog comment list model
    /// </summary>
    public partial record BlogCommentListModel : BasePagedListModel<BlogCommentModel>
    {
    }
}