using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a return request action list model
    /// </summary>
    public partial record ReturnRequestActionListModel : BasePagedListModel<ReturnRequestActionModel>
    {
    }
}