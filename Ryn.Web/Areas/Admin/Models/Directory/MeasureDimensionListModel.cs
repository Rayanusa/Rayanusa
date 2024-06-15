using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a measure dimension list model
    /// </summary>
    public partial record MeasureDimensionListModel : BasePagedListModel<MeasureDimensionModel>
    {
    }
}