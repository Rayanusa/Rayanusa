using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Cms
{
    public partial record RenderWidgetModel : BaseRynModel
    {
        public string WidgetViewComponentName { get; set; }
        public object WidgetViewComponentArguments { get; set; }
    }
}