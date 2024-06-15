﻿using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Templates
{
    /// <summary>
    /// Represents a manufacturer template model
    /// </summary>
    public partial record ManufacturerTemplateModel : BaseRynEntityModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.System.Templates.Manufacturer.Name")]
        public string Name { get; set; }

        [RynResourceDisplayName("Admin.System.Templates.Manufacturer.ViewPath")]
        public string ViewPath { get; set; }

        [RynResourceDisplayName("Admin.System.Templates.Manufacturer.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}