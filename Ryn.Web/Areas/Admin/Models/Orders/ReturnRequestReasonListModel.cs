﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a return request reason list model
    /// </summary>
    public partial record ReturnRequestReasonListModel : BasePagedListModel<ReturnRequestReasonModel>
    {
    }
}