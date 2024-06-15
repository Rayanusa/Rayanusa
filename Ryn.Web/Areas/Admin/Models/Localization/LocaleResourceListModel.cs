using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Localization
{
    /// <summary>
    /// Represents a locale resource list model
    /// </summary>
    public record LocaleResourceListModel : BasePagedListModel<LocaleResourceModel>
    {
    }
}