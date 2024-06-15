using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a GDPR request list model
    /// </summary>
    public partial record GdprLogListModel : BasePagedListModel<GdprLogModel>
    {
    }
}