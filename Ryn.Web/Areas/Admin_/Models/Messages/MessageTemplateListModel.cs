using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Messages
{
    /// <summary>
    /// Represents a message template list model
    /// </summary>
    public partial record MessageTemplateListModel : BasePagedListModel<MessageTemplateModel>
    {
    }
}