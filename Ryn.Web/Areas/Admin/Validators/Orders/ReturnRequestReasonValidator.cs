using FluentValidation;
using Ryn.Core.Domain.Orders;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Web.Areas.Admin.Models.Orders;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.Orders
{
    public partial class ReturnRequestReasonValidator : BaseRynValidator<ReturnRequestReasonModel>
    {
        public ReturnRequestReasonValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Settings.Order.ReturnRequestReasons.Name.Required"));

            SetDatabaseValidationRules<ReturnRequestReason>(mappingEntityAccessor);
        }
    }
}