using FluentValidation;
using Ryn.Core.Domain.Catalog;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Catalog;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Catalog
{
    /// <summary>
    /// Represents a validator for <see cref="SpecificationAttributeGroupModel"/>
    /// </summary>
    public partial class SpecificationAttributeGroupValidator : BaseRynValidator<SpecificationAttributeGroupModel>
    {
        public SpecificationAttributeGroupValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.Attributes.SpecificationAttributes.SpecificationAttributeGroup.Fields.Name.Required"));

            SetDatabaseValidationRules<SpecificationAttributeGroup>(mappingEntityAccessor);
        }
    }
}
