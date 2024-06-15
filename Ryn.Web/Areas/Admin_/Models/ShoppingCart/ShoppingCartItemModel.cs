using System;
using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.ShoppingCart
{
    /// <summary>
    /// Represents a shopping cart item model
    /// </summary>
    public partial record ShoppingCartItemModel : BaseRynEntityModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.CurrentCarts.Store")]
        public string Store { get; set; }

        [RynResourceDisplayName("Admin.CurrentCarts.Product")]
        public int ProductId { get; set; }

        [RynResourceDisplayName("Admin.CurrentCarts.Product")]
        public string ProductName { get; set; }

        public string AttributeInfo { get; set; }

        [RynResourceDisplayName("Admin.CurrentCarts.UnitPrice")]
        public string UnitPrice { get; set; }
        public decimal UnitPriceValue { get; set; }

        [RynResourceDisplayName("Admin.CurrentCarts.Quantity")]
        public int Quantity { get; set; }

        [RynResourceDisplayName("Admin.CurrentCarts.Total")]
        public string Total { get; set; }
        public decimal TotalValue { get; set; }

        [RynResourceDisplayName("Admin.CurrentCarts.UpdatedOn")]
        public DateTime UpdatedOn { get; set; }

        #endregion
    }
}