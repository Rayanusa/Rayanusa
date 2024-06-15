using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a warehouse search model
    /// </summary>
    public partial record WarehouseSearchModel : BaseSearchModel
    {
        [RynResourceDisplayName("Admin.Orders.Shipments.List.Warehouse.SearchName")]
        public string SearchName { get; set; }
    }
}