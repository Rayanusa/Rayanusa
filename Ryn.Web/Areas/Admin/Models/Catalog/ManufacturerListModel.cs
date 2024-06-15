using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a manufacturer list model
    /// </summary>
    public partial record ManufacturerListModel : BasePagedListModel<ManufacturerModel>
    {
    }
}