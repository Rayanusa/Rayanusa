using FluentValidation;
using Ryn.Core.Domain.Shipping;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Shipping;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Shipping
{
    public partial class ShippingMethodValidator : BaseRynValidator<ShippingMethodModel>
    {
        public ShippingMethodValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Shipping.Methods.Fields.Name.Required"));

            SetDatabaseValidationRules<ShippingMethod>(mappingEntityAccessor);
        }
    }
}