using System.Globalization;
using FluentValidation;
using Ryn.Core.Domain.Localization;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Localization;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Localization
{
    public partial class LanguageValidator : BaseRynValidator<LanguageModel>
    {
        public LanguageValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Languages.Fields.Name.Required"));
            RuleFor(x => x.LanguageCulture)
                .Must(x =>
                          {
                              try
                              {
                                  //let's try to create a CultureInfo object
                                  //if "DisplayLocale" is wrong, then exception will be thrown
                                  var unused = new CultureInfo(x);
                                  return true;
                              }
                              catch
                              {
                                  return false;
                              }
                          })
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Languages.Fields.LanguageCulture.Validation"));

            RuleFor(x => x.UniqueSeoCode).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Languages.Fields.UniqueSeoCode.Required"));
            RuleFor(x => x.UniqueSeoCode).Length(2).WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Languages.Fields.UniqueSeoCode.Length"));

            SetDatabaseValidationRules<Language>(mappingEntityAccessor, "UniqueSeoCode");
        }
    }
}