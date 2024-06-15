using FluentValidation;
using Ryn.Core.Domain.Topics;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Templates;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Templates
{
    public partial class TopicTemplateValidator : BaseRynValidator<TopicTemplateModel>
    {
        public TopicTemplateValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.System.Templates.Topic.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.System.Templates.Topic.ViewPath.Required"));

            SetDatabaseValidationRules<TopicTemplate>(mappingEntityAccessor);
        }
    }
}