﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product tag list model
    /// </summary>
    public partial record ProductTagListModel : BasePagedListModel<ProductTagModel>
    {
    }
}