using Ryn.Web.Areas.Admin.Models.Catalog;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a manufacturer list model to add to the discount
    /// </summary>
    public partial record AddManufacturerToDiscountListModel : BasePagedListModel<ManufacturerModel>
    {
    }
}