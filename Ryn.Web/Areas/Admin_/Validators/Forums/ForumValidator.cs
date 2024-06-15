using FluentValidation;
using Ryn.Core.Domain.Forums;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Forums;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Forums
{
    public partial class ForumValidator : BaseRynValidator<ForumModel>
    {
        public ForumValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.Forums.Forum.Fields.Name.Required"));
            RuleFor(x => x.ForumGroupId).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.Forums.Forum.Fields.ForumGroupId.Required"));

            SetDatabaseValidationRules<Forum>(mappingEntityAccessor);
        }
    }
}