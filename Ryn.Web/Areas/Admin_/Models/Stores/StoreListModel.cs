using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Stores
{
    /// <summary>
    /// Represents a store list model
    /// </summary>
    public partial record StoreListModel : BasePagedListModel<StoreModel>
    {
    }
}