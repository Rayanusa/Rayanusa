﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a recurring payment history search model
    /// </summary>
    public partial record RecurringPaymentHistorySearchModel : BaseSearchModel
    {
        #region Properties

        public int RecurringPaymentId { get; set; }

        #endregion
    }
}