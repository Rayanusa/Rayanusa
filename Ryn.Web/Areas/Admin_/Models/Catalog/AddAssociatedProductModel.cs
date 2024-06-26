﻿using System.Collections.Generic;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents an associated product model to add to the product
    /// </summary>
    public partial record AddAssociatedProductModel : BaseRynModel
    {
        #region Ctor

        public AddAssociatedProductModel()
        {
            SelectedProductIds = new List<int>();
        }
        #endregion

        #region Properties

        public int ProductId { get; set; }

        public IList<int> SelectedProductIds { get; set; }

        #endregion
    }
}