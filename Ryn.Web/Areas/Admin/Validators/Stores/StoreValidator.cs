using FluentValidation;
using Ryn.Core.Domain.Stores;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Stores;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Stores
{
    public partial class StoreValidator : BaseRynValidator<StoreModel>
    {
        public StoreValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Stores.Fields.Name.Required"));
            RuleFor(x => x.Url).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Stores.Fields.Url.Required"));

            SetDatabaseValidationRules<Store>(mappingEntityAccessor);
        }
    }
}