using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.ExternalAuthentication
{
    /// <summary>
    /// Represents an external authentication method list model
    /// </summary>
    public partial record ExternalAuthenticationMethodListModel : BasePagedListModel<ExternalAuthenticationMethodModel>
    {
    }
}