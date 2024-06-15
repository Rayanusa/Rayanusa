using FluentValidation;
using Ryn.Core.Domain.Shipping;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Shipping;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Shipping
{
    public partial class WarehouseValidator : BaseRynValidator<WarehouseModel>
    {
        public WarehouseValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Shipping.Warehouses.Fields.Name.Required"));

            SetDatabaseValidationRules<Warehouse>(mappingEntityAccessor);
        }
    }
}