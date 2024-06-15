using FluentValidation;
using Ryn.Core.Domain.Catalog;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Services.Seo;
using Ryn.Web.Areas.Admin.Models.Catalog;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Catalog
{
    public partial class ProductValidator : BaseRynValidator<ProductModel>
    {
        public ProductValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.Products.Fields.Name.Required"));
            
            RuleFor(x => x.SeName)
                .Length(0, RynSeoDefaults.SearchEngineNameLength)
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.SEO.SeName.MaxLengthValidation"), RynSeoDefaults.SearchEngineNameLength);
            
            RuleFor(x => x.RentalPriceLength)
                .GreaterThan(0)
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.Products.Fields.RentalPriceLength.ShouldBeGreaterThanZero"))
                .When(x => x.IsRental);

            SetDatabaseValidationRules<Product>(mappingEntityAccessor);
        }
    }
}