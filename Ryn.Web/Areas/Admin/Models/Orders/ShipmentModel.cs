using System;
using System.Collections.Generic;
using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a shipment model
    /// </summary>
    public partial record ShipmentModel : BaseRynEntityModel
    {
        #region Ctor

        public ShipmentModel()
        {
            ShipmentStatusEvents = new List<ShipmentStatusEventModel>();
            Items = new List<ShipmentItemModel>();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.Orders.Shipments.ID")]
        public override int Id { get; set; }

        public int OrderId { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.PickupInStore")]
        public bool PickupInStore { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.TotalWeight")]
        public string TotalWeight { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.TrackingNumber")]
        public string TrackingNumber { get; set; }

        public string TrackingNumberUrl { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.ShippedDate")]
        public string ShippedDate { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.CanShip")]
        public bool CanShip { get; set; }

        public DateTime? ShippedDateUtc { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.ReadyForPickupDate")]
        public string ReadyForPickupDate { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.CanMarkAsReadyForPickup")]
        public bool CanMarkAsReadyForPickup { get; set; }

        public DateTime? ReadyForPickupDateUtc { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.DeliveryDate")]
        public string DeliveryDate { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.CanDeliver")]
        public bool CanDeliver { get; set; }

        public DateTime? DeliveryDateUtc { get; set; }

        [RynResourceDisplayName("Admin.Orders.Shipments.AdminComment")]
        public string AdminComment { get; set; }

        public List<ShipmentItemModel> Items { get; set; }

        public IList<ShipmentStatusEventModel> ShipmentStatusEvents { get; set; }

        #endregion
    }
}