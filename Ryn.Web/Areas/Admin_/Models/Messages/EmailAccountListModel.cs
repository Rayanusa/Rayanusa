using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Messages
{
    /// <summary>
    /// Represents an email account list model
    /// </summary>
    public partial record EmailAccountListModel : BasePagedListModel<EmailAccountModel>
    {
    }
}