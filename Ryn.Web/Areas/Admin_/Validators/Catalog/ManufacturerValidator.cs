using FluentValidation;
using Ryn.Core.Domain.Catalog;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Services.Seo;
using Ryn.Web.Areas.Admin.Models.Catalog;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Catalog
{
    public partial class ManufacturerValidator : BaseRynValidator<ManufacturerModel>
    {
        public ManufacturerValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.Manufacturers.Fields.Name.Required"));
            RuleFor(x => x.PageSizeOptions).Must(ValidatorUtilities.PageSizeOptionsValidator).WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.Manufacturers.Fields.PageSizeOptions.ShouldHaveUniqueItems"));
            RuleFor(x => x.PageSize).Must((x, context) =>
            {
                if (!x.AllowCustomersToSelectPageSize && x.PageSize <= 0)
                    return false;

                return true;
            }).WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.Manufacturers.Fields.PageSize.Positive"));
            RuleFor(x => x.SeName).Length(0, RynSeoDefaults.SearchEngineNameLength)
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.SEO.SeName.MaxLengthValidation"), RynSeoDefaults.SearchEngineNameLength);

            RuleFor(x => x.PriceFrom)
                .GreaterThanOrEqualTo(0)
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.Manufacturers.Fields.PriceFrom.GreaterThanOrEqualZero"))
                .When(x => x.PriceRangeFiltering && x.ManuallyPriceRange);

            RuleFor(x => x.PriceTo)
                .GreaterThan(x => x.PriceFrom > decimal.Zero ? x.PriceFrom : decimal.Zero)
                .WithMessage(x => string.Format(localizationService.GetResourceAsync("Admin.Catalog.Manufacturers.Fields.PriceTo.GreaterThanZeroOrPriceFrom").Result, x.PriceFrom > decimal.Zero ? x.PriceFrom : decimal.Zero))
                .When(x => x.PriceRangeFiltering && x.ManuallyPriceRange);

            SetDatabaseValidationRules<Manufacturer>(mappingEntityAccessor);
        }
    }
}