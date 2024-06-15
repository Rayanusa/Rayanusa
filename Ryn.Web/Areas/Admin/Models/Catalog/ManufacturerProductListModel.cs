using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a manufacturer product list model
    /// </summary>
    public partial record ManufacturerProductListModel : BasePagedListModel<ManufacturerProductModel>
    {
    }
}