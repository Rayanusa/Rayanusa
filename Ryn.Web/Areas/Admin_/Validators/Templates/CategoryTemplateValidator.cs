using FluentValidation;
using Ryn.Core.Domain.Catalog;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Templates;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Templates
{
    public partial class CategoryTemplateValidator : BaseRynValidator<CategoryTemplateModel>
    {
        public CategoryTemplateValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.System.Templates.Category.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.System.Templates.Category.ViewPath.Required"));

            SetDatabaseValidationRules<CategoryTemplate>(mappingEntityAccessor);
        }
    }
}