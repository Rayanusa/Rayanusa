using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a sort option list model
    /// </summary>
    public partial record SortOptionListModel : BasePagedListModel<SortOptionModel>
    {
    }
}