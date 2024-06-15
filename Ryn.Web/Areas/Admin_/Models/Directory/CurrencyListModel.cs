﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a currency list model
    /// </summary>
    public partial record CurrencyListModel : BasePagedListModel<CurrencyModel>
    {
    }
}