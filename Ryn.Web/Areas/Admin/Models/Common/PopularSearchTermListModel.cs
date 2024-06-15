using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents a popular search term list model
    /// </summary>
    public partial record PopularSearchTermListModel : BasePagedListModel<PopularSearchTermModel>
    {
    }
}