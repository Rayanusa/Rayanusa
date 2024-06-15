using FluentValidation;
using Ryn.Core.Domain.Messages;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Messages;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Messages
{
    public partial class CampaignValidator : BaseRynValidator<CampaignModel>
    {
        public CampaignValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Promotions.Campaigns.Fields.Name.Required"));

            RuleFor(x => x.Subject).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Promotions.Campaigns.Fields.Subject.Required"));

            RuleFor(x => x.Body).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Promotions.Campaigns.Fields.Body.Required"));

            SetDatabaseValidationRules<Campaign>(mappingEntityAccessor);
        }
    }
}