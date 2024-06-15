﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Affiliates
{
    /// <summary>
    /// Represents an affiliated order list model
    /// </summary>
    public partial record AffiliatedOrderListModel : BasePagedListModel<AffiliatedOrderModel>
    {
    }
}