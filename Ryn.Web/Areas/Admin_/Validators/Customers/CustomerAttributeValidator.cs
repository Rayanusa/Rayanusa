using FluentValidation;
using Ryn.Core.Domain.Customers;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Customers;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Customers
{
    public partial class CustomerAttributeValidator : BaseRynValidator<CustomerAttributeModel>
    {
        public CustomerAttributeValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Customers.CustomerAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<CustomerAttribute>(mappingEntityAccessor);
        }
    }
}