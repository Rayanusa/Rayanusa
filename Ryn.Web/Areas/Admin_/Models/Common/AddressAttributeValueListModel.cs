using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents an address attribute value list model
    /// </summary>
    public record AddressAttributeValueListModel : BasePagedListModel<AddressAttributeValueModel>
    {
    }
}