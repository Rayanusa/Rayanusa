using System.Collections.Generic;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a specification attribute group model
    /// </summary>
    public partial record SpecificationAttributeGroupModel : BaseRynEntityModel, ILocalizedModel<SpecificationAttributeGroupLocalizedModel>
    {
        #region Ctor

        public SpecificationAttributeGroupModel()
        {
            Locales = new List<SpecificationAttributeGroupLocalizedModel>();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttributeGroup.Fields.Name")]
        public string Name { get; set; }

        [RynResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttributeGroup.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<SpecificationAttributeGroupLocalizedModel> Locales { get; set; }

        #endregion
    }
}
