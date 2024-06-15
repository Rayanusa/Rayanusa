using FluentValidation;
using Ryn.Core.Domain.Catalog;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Templates;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Templates
{
    public partial class ManufacturerTemplateValidator : BaseRynValidator<ManufacturerTemplateModel>
    {
        public ManufacturerTemplateValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.System.Templates.Manufacturer.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.System.Templates.Manufacturer.ViewPath.Required"));

            SetDatabaseValidationRules<ManufacturerTemplate>(mappingEntityAccessor);
        }
    }
}