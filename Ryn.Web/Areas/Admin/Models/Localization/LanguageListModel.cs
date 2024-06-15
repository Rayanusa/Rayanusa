using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Localization
{
    /// <summary>
    /// Represents a language list model
    /// </summary>
    public partial record LanguageListModel : BasePagedListModel<LanguageModel>
    {
    }
}