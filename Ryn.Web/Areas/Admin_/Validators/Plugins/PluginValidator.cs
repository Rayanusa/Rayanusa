using FluentValidation;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Plugins;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Plugins
{
    public partial class PluginValidator : BaseRynValidator<PluginModel>
    {
        public PluginValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.FriendlyName).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Plugins.Fields.FriendlyName.Required"));
        }
    }
}