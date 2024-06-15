using FluentValidation;
using Ryn.Core.Domain.Directory;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Directory;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Directory
{
    public partial class MeasureWeightValidator : BaseRynValidator<MeasureWeightModel>
    {
        public MeasureWeightValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Shipping.Measures.Weights.Fields.Name.Required"));
            RuleFor(x => x.SystemKeyword).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Shipping.Measures.Weights.Fields.SystemKeyword.Required"));

            SetDatabaseValidationRules<MeasureWeight>(mappingEntityAccessor);
        }
    }
}