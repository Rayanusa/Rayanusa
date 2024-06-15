using FluentValidation;
using Ryn.Core.Domain.Vendors;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Vendors;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Vendors
{
    public partial class VendorAttributeValidator : BaseRynValidator<VendorAttributeModel>
    {
        public VendorAttributeValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Vendors.VendorAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<VendorAttribute>(mappingEntityAccessor);
        }
    }
}