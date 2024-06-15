using FluentValidation;
using Ryn.Core.Domain.Localization;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Localization;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Localization
{
    public partial class LanguageResourceValidator : BaseRynValidator<LocaleResourceModel>
    {
        public LanguageResourceValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            //if validation without this set rule is applied, in this case nothing will be validated
            //it's used to prevent auto-validation of child models
            RuleSet(RynValidationDefaults.ValidationRuleSet, () =>
            {
                RuleFor(model => model.ResourceName)
                    .NotEmpty()
                    .WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Languages.Resources.Fields.Name.Required"));

                RuleFor(model => model.ResourceValue)
                    .NotEmpty()
                    .WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Languages.Resources.Fields.Value.Required"));

                SetDatabaseValidationRules<LocaleStringResource>(mappingEntityAccessor);
            });
        }
    }
}