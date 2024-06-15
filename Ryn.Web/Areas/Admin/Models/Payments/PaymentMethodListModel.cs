using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Payments
{
    /// <summary>
    /// Represents a payment method list model
    /// </summary>
    public partial record PaymentMethodListModel : BasePagedListModel<PaymentMethodModel>
    {
    }
}