using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Cms
{
    /// <summary>
    /// Represents a widget list model
    /// </summary>
    public partial record WidgetListModel : BasePagedListModel<WidgetModel>
    {
    }
}