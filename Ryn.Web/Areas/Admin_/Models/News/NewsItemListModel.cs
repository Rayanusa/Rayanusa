using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.News
{
    /// <summary>
    /// Represents a news item list model
    /// </summary>
    public partial record NewsItemListModel : BasePagedListModel<NewsItemModel>
    {
    }
}