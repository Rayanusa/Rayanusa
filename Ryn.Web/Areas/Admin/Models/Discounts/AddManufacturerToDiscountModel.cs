﻿using System.Collections.Generic;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a manufacturer model to add to the discount
    /// </summary>
    public partial record AddManufacturerToDiscountModel : BaseRynModel
    {
        #region Ctor

        public AddManufacturerToDiscountModel()
        {
            SelectedManufacturerIds = new List<int>();
        }
        #endregion

        #region Properties

        public int DiscountId { get; set; }

        public IList<int> SelectedManufacturerIds { get; set; }

        #endregion
    }
}