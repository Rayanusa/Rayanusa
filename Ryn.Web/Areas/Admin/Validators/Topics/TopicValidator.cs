using FluentValidation;
using Ryn.Core.Domain.Topics;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Services.Seo;
using Ryn.Web.Areas.Admin.Models.Topics;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Topics
{
    public partial class TopicValidator : BaseRynValidator<TopicModel>
    {
        public TopicValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.SeName)
                .Length(0, RynSeoDefaults.ForumTopicLength)
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.SEO.SeName.MaxLengthValidation"), RynSeoDefaults.ForumTopicLength);

            RuleFor(x => x.Password)
                .NotEmpty()
                .When(x => x.IsPasswordProtected)
                .WithMessageAwait(localizationService.GetResourceAsync("Validation.Password.IsNotEmpty"));

            SetDatabaseValidationRules<Topic>(mappingEntityAccessor);
        }
    }
}
