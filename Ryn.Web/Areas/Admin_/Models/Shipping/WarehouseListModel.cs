using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a warehouse list model
    /// </summary>
    public partial record WarehouseListModel : BasePagedListModel<WarehouseModel>
    {
    }
}