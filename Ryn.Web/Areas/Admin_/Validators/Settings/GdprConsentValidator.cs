using FluentValidation;
using Ryn.Core.Domain.Gdpr;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Settings;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Settings
{
    public partial class GdprConsentValidator : BaseRynValidator<GdprConsentModel>
    {
        public GdprConsentValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Message).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Settings.Gdpr.Consent.Message.Required"));
            RuleFor(x => x.RequiredMessage)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Settings.Gdpr.Consent.RequiredMessage.Required"))
                .When(x => x.IsRequired);

            SetDatabaseValidationRules<GdprConsent>(mappingEntityAccessor);
        }
    }
}