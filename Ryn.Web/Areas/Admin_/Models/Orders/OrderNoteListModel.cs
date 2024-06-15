using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an order note list model
    /// </summary>
    public partial record OrderNoteListModel : BasePagedListModel<OrderNoteModel>
    {
    }
}