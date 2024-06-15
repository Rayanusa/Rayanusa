using FluentValidation;
using Ryn.Core.Domain.Customers;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Customers;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Customers
{
    public partial class CustomerAttributeValueValidator : BaseRynValidator<CustomerAttributeValueModel>
    {
        public CustomerAttributeValueValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Customers.CustomerAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<CustomerAttributeValue>(mappingEntityAccessor);
        }
    }
}