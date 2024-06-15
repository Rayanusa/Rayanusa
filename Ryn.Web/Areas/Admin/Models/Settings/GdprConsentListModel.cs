using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a GDPR consent list model
    /// </summary>
    public partial record GdprConsentListModel : BasePagedListModel<GdprConsentModel>
    {
    }
}