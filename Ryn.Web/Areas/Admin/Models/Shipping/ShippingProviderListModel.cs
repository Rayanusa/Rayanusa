﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a shipping provider list model
    /// </summary>
    public partial record ShippingProviderListModel : BasePagedListModel<ShippingProviderModel>
    {
    }
}