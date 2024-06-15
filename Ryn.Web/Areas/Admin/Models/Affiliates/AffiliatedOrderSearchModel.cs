﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Affiliates
{
    /// <summary>
    /// Represents an affiliated order search model
    /// </summary>
    public partial record AffiliatedOrderSearchModel : BaseSearchModel
    {
        #region Ctor

        public AffiliatedOrderSearchModel()
        {
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableShippingStatuses = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public int AffliateId { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
        public int OrderStatusId { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.PaymentStatus")]
        public int PaymentStatusId { get; set; }

        [RynResourceDisplayName("Admin.Affiliates.Orders.ShippingStatus")]
        public int ShippingStatusId { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; }
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
        public IList<SelectListItem> AvailableShippingStatuses { get; set; }

        #endregion
    }
}