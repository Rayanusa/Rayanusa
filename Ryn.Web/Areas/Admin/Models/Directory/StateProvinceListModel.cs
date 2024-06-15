using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a state and province list model
    /// </summary>
    public record StateProvinceListModel : BasePagedListModel<StateProvinceModel>
    {
    }
}