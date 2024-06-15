using FluentValidation;
using Ryn.Core.Domain.Polls;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Polls;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Polls
{
    public partial class PollValidator : BaseRynValidator<PollModel>
    {
        public PollValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.Polls.Fields.Name.Required"));

            SetDatabaseValidationRules<Poll>(mappingEntityAccessor);
        }
    }
}