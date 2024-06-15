using FluentValidation;
using Ryn.Core.Domain.Discounts;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Discounts;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Discounts
{
    public partial class DiscountValidator : BaseRynValidator<DiscountModel>
    {
        public DiscountValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Promotions.Discounts.Fields.Name.Required"));

            SetDatabaseValidationRules<Discount>(mappingEntityAccessor);
        }
    }
}