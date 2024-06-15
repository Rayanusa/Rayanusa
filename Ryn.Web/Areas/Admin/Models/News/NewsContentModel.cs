using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.News
{
    /// <summary>
    /// Represents a news content model
    /// </summary>
    public partial record NewsContentModel : BaseRynModel
    {
        #region Ctor

        public NewsContentModel()
        {
            NewsItems = new NewsItemSearchModel();
            NewsComments = new NewsCommentSearchModel();
            SearchTitle = new NewsItemSearchModel().SearchTitle;
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.ContentManagement.News.NewsItems.List.SearchTitle")]
        public string SearchTitle { get; set; }

        public NewsItemSearchModel NewsItems { get; set; }

        public NewsCommentSearchModel NewsComments { get; set; }

        #endregion
    }
}
