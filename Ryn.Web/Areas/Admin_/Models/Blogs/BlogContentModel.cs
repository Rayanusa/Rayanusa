using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Blogs
{
    /// <summary>
    /// Represents a blog content model
    /// </summary>
    public partial record BlogContentModel : BaseRynModel
    {
        #region Ctor

        public BlogContentModel()
        {
            BlogPosts = new BlogPostSearchModel();
            BlogComments = new BlogCommentSearchModel();
            SearchTitle = new BlogPostSearchModel().SearchTitle;
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.ContentManagement.Blog.BlogPosts.List.SearchTitle")]
        public string SearchTitle { get; set; }

        public BlogPostSearchModel BlogPosts { get; set; }

        public BlogCommentSearchModel BlogComments { get; set; }

        #endregion
    }
}
