using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    public partial record SalesSummarySearchModel : BaseSearchModel
    {
        #region Ctor

        public SalesSummarySearchModel()
        {
            AvailableStores = new List<SelectListItem>();
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
            GroupByOptions = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.Reports.SalesSummary.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Store")]
        public int StoreId { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.OrderStatus")]
        public int OrderStatusId { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.PaymentStatus")]
        public int PaymentStatusId { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Category")]
        public int CategoryId { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Manufacturer")]
        public int ManufacturerId { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.BillingCountry")]
        public int BillingCountryId { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.Product")]
        public int ProductId { get; set; }

        [RynResourceDisplayName("Admin.Reports.SalesSummary.GroupBy")]
        public int SearchGroupId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; }

        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }

        public IList<SelectListItem> AvailableCategories { get; set; }

        public IList<SelectListItem> AvailableManufacturers { get; set; }

        public IList<SelectListItem> AvailableCountries { get; set; }
        
        public IList<SelectListItem> GroupByOptions { get; set; }

        public bool IsLoggedInAsVendor { get; set; }

        #endregion
    }
}
