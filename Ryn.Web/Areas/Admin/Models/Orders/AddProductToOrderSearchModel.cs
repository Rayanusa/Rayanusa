﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a product search model to add to the order
    /// </summary>
    public partial record AddProductToOrderSearchModel : BaseSearchModel
    {
        #region Ctor

        public AddProductToOrderSearchModel()
        {
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableProductTypes = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]
        public string SearchProductName { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
        public int SearchCategoryId { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
        public int SearchManufacturerId { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
        public int SearchProductTypeId { get; set; }

        public IList<SelectListItem> AvailableCategories { get; set; }

        public IList<SelectListItem> AvailableManufacturers { get; set; }

        public IList<SelectListItem> AvailableProductTypes { get; set; }

        public int OrderId { get; set; }

        #endregion
    }
}