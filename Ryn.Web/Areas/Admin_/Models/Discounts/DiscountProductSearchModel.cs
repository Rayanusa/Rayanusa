﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount product search model
    /// </summary>
    public partial record DiscountProductSearchModel : BaseSearchModel
    {
        #region Properties

        public int DiscountId { get; set; }

        #endregion
    }
}