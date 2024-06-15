using FluentValidation;
using Ryn.Core.Domain.Configuration;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Settings;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Settings
{
    public partial class SettingValidator : BaseRynValidator<SettingModel>
    {
        public SettingValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Settings.AllSettings.Fields.Name.Required"));

            SetDatabaseValidationRules<Setting>(mappingEntityAccessor);
        }
    }
}