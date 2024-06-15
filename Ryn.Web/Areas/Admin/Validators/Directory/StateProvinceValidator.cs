using FluentValidation;
using Ryn.Core.Domain.Directory;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Directory;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Directory
{
    public partial class StateProvinceValidator : BaseRynValidator<StateProvinceModel>
    {
        public StateProvinceValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Countries.States.Fields.Name.Required"));

            SetDatabaseValidationRules<StateProvince>(mappingEntityAccessor);
        }
    }
}