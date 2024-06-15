using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Templates
{
    /// <summary>
    /// Represents a topic template list model
    /// </summary>
    public partial record TopicTemplateListModel : BasePagedListModel<TopicTemplateModel>
    {
    }
}