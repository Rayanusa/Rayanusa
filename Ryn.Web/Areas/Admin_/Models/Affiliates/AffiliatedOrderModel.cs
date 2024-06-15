using System;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Affiliates
{
    /// <summary>
    /// Represents an affiliated order model
    /// </summary>
    public partial record AffiliatedOrderModel : BaseRynEntityModel
    {
        #region Properties

        public override int Id { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
        public string OrderStatus { get; set; }
        [RynResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
        public int OrderStatusId { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.PaymentStatus")]
        public string PaymentStatus { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.ShippingStatus")]
        public string ShippingStatus { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.OrderTotal")]
        public string OrderTotal { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}