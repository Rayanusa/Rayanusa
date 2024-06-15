using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Topics
{
    /// <summary>
    /// Represents a topic list model
    /// </summary>
    public partial record TopicListModel : BasePagedListModel<TopicModel>
    {
    }
}