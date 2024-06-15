using FluentValidation;
using Ryn.Core;
using Ryn.Core.Domain.Catalog;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Catalog;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Catalog
{
    public partial class ProductReviewValidator : BaseRynValidator<ProductReviewModel>
    {
        public ProductReviewValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor, IWorkContext workContext)
        {
            var isLoggedInAsVendor = workContext.GetCurrentVendorAsync().Result != null;
            //vendor can edit "Reply text" only
            if (!isLoggedInAsVendor)
            {
                RuleFor(x => x.Title).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.ProductReviews.Fields.Title.Required"));
                RuleFor(x => x.ReviewText).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.ProductReviews.Fields.ReviewText.Required"));
            }

            SetDatabaseValidationRules<ProductReview>(mappingEntityAccessor);
        }
    }
}