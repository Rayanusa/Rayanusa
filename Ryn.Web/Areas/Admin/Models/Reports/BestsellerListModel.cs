using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a bestseller list model
    /// </summary>
    public partial record BestsellerListModel : BasePagedListModel<BestsellerModel>
    {
    }
}