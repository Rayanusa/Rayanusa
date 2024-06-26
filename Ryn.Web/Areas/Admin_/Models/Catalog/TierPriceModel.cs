﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a tier price model
    /// </summary>
    public partial record TierPriceModel : BaseRynEntityModel
    {
        #region Ctor

        public TierPriceModel()
        {
            AvailableStores = new List<SelectListItem>();
            AvailableCustomerRoles = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public int ProductId { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.CustomerRole")]
        public int CustomerRoleId { get; set; }

        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        public string CustomerRole { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.Store")]
        public int StoreId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public string Store { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.Quantity")]
        public int Quantity { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.Price")]
        public decimal Price { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.StartDateTimeUtc")]
        [UIHint("DateTimeNullable")]
        public DateTime? StartDateTimeUtc { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.EndDateTimeUtc")]
        [UIHint("DateTimeNullable")]
        public DateTime? EndDateTimeUtc { get; set; }

        #endregion
    }
}