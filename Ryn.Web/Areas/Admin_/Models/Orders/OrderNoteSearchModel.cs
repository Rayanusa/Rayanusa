using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an order note search model
    /// </summary>
    public partial record OrderNoteSearchModel : BaseSearchModel
    {
        #region Properties

        public  int OrderId { get; set; }

        #endregion
    }
}