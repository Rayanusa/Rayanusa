using FluentValidation;
using Ryn.Core.Domain.Tax;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Tax;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Tax
{
    public partial class TaxCategoryValidator : BaseRynValidator<TaxCategoryModel>
    {
        public TaxCategoryValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Tax.Categories.Fields.Name.Required"));

            SetDatabaseValidationRules<TaxCategory>(mappingEntityAccessor);
        }
    }
}