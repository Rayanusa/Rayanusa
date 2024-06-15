using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a model for adding or editing a specification attribute
    /// </summary>
    public partial record AddSpecificationAttributeModel : BaseRynEntityModel, ILocalizedModel<AddSpecificationAttributeLocalizedModel>
    {
        #region Ctor

        public AddSpecificationAttributeModel()
        {
            AvailableOptions = new List<SelectListItem>();
            AvailableAttributes = new List<SelectListItem>();
            ShowOnProductPage = true;
            AttributeName = string.Empty;
            AttributeTypeName = string.Empty;
            Value = string.Empty;
            ValueRaw = string.Empty;
            Locales = new List<AddSpecificationAttributeLocalizedModel>();
        }

        #endregion

        #region Properties

        public int SpecificationId { get; set; }

        public int AttributeTypeId { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AttributeType")]
        public string AttributeTypeName { get; set; }

        public int AttributeId { get; set; }

        public int ProductId { get; set; }

        public IList<SelectListItem> AvailableAttributes { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttribute")]
        public string AttributeName { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.CustomValue")]
        public string ValueRaw { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.CustomValue")]
        public string Value { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AllowFiltering")]
        public bool AllowFiltering { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.ShowOnProductPage")]
        public bool ShowOnProductPage { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttributeOption")]
        public int SpecificationAttributeOptionId { get; set; }

        public IList<SelectListItem> AvailableOptions { get; set; }

        public IList<AddSpecificationAttributeLocalizedModel> Locales { get; set; }

        #endregion
    }
}