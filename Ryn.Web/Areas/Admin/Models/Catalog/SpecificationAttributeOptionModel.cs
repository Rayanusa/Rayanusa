﻿using System.Collections.Generic;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a specification attribute option model
    /// </summary>
    public partial record SpecificationAttributeOptionModel : BaseRynEntityModel, ILocalizedModel<SpecificationAttributeOptionLocalizedModel>
    {
        #region Ctor

        public SpecificationAttributeOptionModel()
        {
            Locales = new List<SpecificationAttributeOptionLocalizedModel>();
        }

        #endregion

        #region Properties

        public int SpecificationAttributeId { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttribute.Options.Fields.Name")]
        public string Name { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttribute.Options.Fields.ColorSquaresRgb")]
        public string ColorSquaresRgb { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttribute.Options.Fields.EnableColorSquaresRgb")]
        public bool EnableColorSquaresRgb { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttribute.Options.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttribute.Options.Fields.NumberOfAssociatedProducts")]
        public int NumberOfAssociatedProducts { get; set; }
        
        public IList<SpecificationAttributeOptionLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial record SpecificationAttributeOptionLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttribute.Options.Fields.Name")]
        public string Name { get; set; }
    }    
}