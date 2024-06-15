using FluentValidation;
using Ryn.Core.Domain.Common;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Common;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Common
{
    public partial class AddressAttributeValueValidator : BaseRynValidator<AddressAttributeValueModel>
    {
        public AddressAttributeValueValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Address.AddressAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<AddressAttributeValue>(mappingEntityAccessor);
        }
    }
}