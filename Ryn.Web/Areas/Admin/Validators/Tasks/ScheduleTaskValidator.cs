using FluentValidation;
using Ryn.Core.Domain.ScheduleTasks;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Tasks;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Tasks
{
    public partial class ScheduleTaskValidator : BaseRynValidator<ScheduleTaskModel>
    {
        public ScheduleTaskValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.System.ScheduleTasks.Name.Required"));
            RuleFor(x => x.Seconds).GreaterThan(0).WithMessageAwait(localizationService.GetResourceAsync("Admin.System.ScheduleTasks.Seconds.Positive"));

            SetDatabaseValidationRules<ScheduleTask>(mappingEntityAccessor);
        }
    }
}