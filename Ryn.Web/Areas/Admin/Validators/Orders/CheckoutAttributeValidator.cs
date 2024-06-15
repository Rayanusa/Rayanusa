using FluentValidation;
using Ryn.Core.Domain.Orders;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Orders;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Orders
{
    public partial class CheckoutAttributeValidator : BaseRynValidator<CheckoutAttributeModel>
    {
        public CheckoutAttributeValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Catalog.Attributes.CheckoutAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<CheckoutAttribute>(mappingEntityAccessor);
        }
    }
}