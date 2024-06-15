using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a bestseller brief list model
    /// </summary>
    public record BestsellerBriefListModel : BasePagedListModel<BestsellerModel>
    {
    }
}