using Ryn.Web.Areas.Admin.Models.ShoppingCart;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer shopping cart list model
    /// </summary>
    public partial record CustomerShoppingCartListModel : BasePagedListModel<ShoppingCartItemModel>
    {
    }
}