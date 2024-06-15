using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a reward points model to add to the customer
    /// </summary>
    public partial record AddRewardPointsToCustomerModel : BaseRynModel
    {
        #region Ctor

        public AddRewardPointsToCustomerModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public int CustomerId { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Points")]
        public int Points { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Message")]
        public string Message { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Store")]
        public int StoreId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.ActivatePointsImmediately")]
        public bool ActivatePointsImmediately { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.ActivationDelay")]
        public int ActivationDelay { get; set; }

        public int ActivationDelayPeriodId { get; set; }

        [RynResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.PointsValidity")]
        [UIHint("Int32Nullable")]
        public int? PointsValidity { get; set; }

        #endregion
    }
}