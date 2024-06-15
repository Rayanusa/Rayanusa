using System;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer order model
    /// </summary>
    public partial record CustomerOrderModel : BaseRynEntityModel
    {
        #region Properties

        public override int Id { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.Orders.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.Orders.OrderStatus")]
        public string OrderStatus { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.Orders.OrderStatus")]
        public int OrderStatusId { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.Orders.PaymentStatus")]
        public string PaymentStatus { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.Orders.ShippingStatus")]
        public string ShippingStatus { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.Orders.OrderTotal")]
        public string OrderTotal { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.Orders.Store")]
        public string StoreName { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.Orders.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}