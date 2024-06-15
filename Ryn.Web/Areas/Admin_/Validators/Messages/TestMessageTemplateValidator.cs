using FluentValidation;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Messages;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Messages
{
    public partial class TestMessageTemplateValidator : BaseRynValidator<TestMessageTemplateModel>
    {
        public TestMessageTemplateValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.SendTo).NotEmpty();
            RuleFor(x => x.SendTo).EmailAddress().WithMessageAwait(localizationService.GetResourceAsync("Admin.Common.WrongEmail"));
        }
    }
}