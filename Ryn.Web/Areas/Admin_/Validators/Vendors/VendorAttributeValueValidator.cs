using FluentValidation;
using Ryn.Core.Domain.Vendors;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Vendors;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Vendors
{
    public partial class VendorAttributeValueValidator : BaseRynValidator<VendorAttributeValueModel>
    {
        public VendorAttributeValueValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Vendors.VendorAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<VendorAttributeValue>(mappingEntityAccessor);
        }
    }
}