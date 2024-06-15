using FluentValidation;
using Ryn.Core.Domain.Polls;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Polls;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Polls
{
    public partial class PollAnswerValidator : BaseRynValidator<PollAnswerModel>
    {
        public PollAnswerValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            //if validation without this set rule is applied, in this case nothing will be validated
            //it's used to prevent auto-validation of child models
            RuleSet(RynValidationDefaults.ValidationRuleSet, () =>
            {
                RuleFor(model => model.Name)
                    .NotEmpty()
                    .WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.Polls.Answers.Fields.Name.Required"));

                SetDatabaseValidationRules<PollAnswer>(mappingEntityAccessor);
            });
        }
    }
}