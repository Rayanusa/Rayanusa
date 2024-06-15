﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor note search model
    /// </summary>
    public partial record VendorNoteSearchModel : BaseSearchModel
    {
        #region Properties

        public int VendorId { get; set; }
        
        #endregion
    }
}