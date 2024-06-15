using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product picture list model
    /// </summary>
    public partial record ProductPictureListModel : BasePagedListModel<ProductPictureModel>
    {
    }
}