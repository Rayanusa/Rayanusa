using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents an address attribute list model
    /// </summary>
    public record AddressAttributeListModel : BasePagedListModel<AddressAttributeModel>
    {
    }
}