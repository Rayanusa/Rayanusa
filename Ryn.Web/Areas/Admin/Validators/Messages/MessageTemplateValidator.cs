using FluentValidation;
using Ryn.Core.Domain.Messages;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Messages;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Messages
{
    public partial class MessageTemplateValidator : BaseRynValidator<MessageTemplateModel>
    {
        public MessageTemplateValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.MessageTemplates.Fields.Subject.Required"));
            RuleFor(x => x.Body).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.MessageTemplates.Fields.Body.Required"));

            SetDatabaseValidationRules<MessageTemplate>(mappingEntityAccessor);
        }
    }
}