﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor attribute value list model
    /// </summary>
    public partial record VendorAttributeValueListModel : BasePagedListModel<VendorAttributeValueModel>
    {
    }
}