using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Core.Domain.Orders;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.ShoppingCart
{
    /// <summary>
    /// Represents a shopping cart search model
    /// </summary>
    public partial record ShoppingCartSearchModel : BaseSearchModel
    {
        #region Ctor

        public ShoppingCartSearchModel()
        {
            AvailableShoppingCartTypes = new List<SelectListItem>();
            ShoppingCartItemSearchModel = new ShoppingCartItemSearchModel();
            AvailableStores = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.ShoppingCartType.ShoppingCartType")]
        public ShoppingCartType ShoppingCartType { get; set; }

        [RynResourceDisplayName("Admin.ShoppingCartType.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [RynResourceDisplayName("Admin.ShoppingCartType.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [RynResourceDisplayName("Admin.ShoppingCartType.Product")]
        public int ProductId { get; set; }

        [RynResourceDisplayName("Admin.ShoppingCartType.BillingCountry")]
        public int BillingCountryId { get; set; }

        [RynResourceDisplayName("Admin.ShoppingCartType.Store")]
        public int StoreId { get; set; }

        public IList<SelectListItem> AvailableShoppingCartTypes { get; set; }

        public ShoppingCartItemSearchModel ShoppingCartItemSearchModel { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public IList<SelectListItem> AvailableCountries { get; set; }

        public bool HideStoresList { get; set; }

        #endregion
    }
}