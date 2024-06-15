using FluentValidation;
using Ryn.Core.Domain.Forums;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Forums;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Forums
{
    public partial class ForumGroupValidator : BaseRynValidator<ForumGroupModel>
    {
        public ForumGroupValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.Forums.ForumGroup.Fields.Name.Required"));

            SetDatabaseValidationRules<ForumGroup>(mappingEntityAccessor);
        }
    }
}