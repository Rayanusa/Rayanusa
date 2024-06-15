using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents an URL record list model
    /// </summary>
    public partial record UrlRecordListModel : BasePagedListModel<UrlRecordModel>
    {
    }
}