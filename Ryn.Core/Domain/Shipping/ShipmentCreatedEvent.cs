﻿namespace Ryn.Core.Domain.Shipping
{
    /// <summary>
    /// Shipment created event
    /// </summary>
    public class ShipmentCreatedEvent
    {
        #region Ctor

        public ShipmentCreatedEvent(Shipment shipment)
        {
            Shipment = shipment;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the shipment
        /// </summary>
        public Shipment Shipment { get; }

        #endregion
    }
}