using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a specification attribute list model
    /// </summary>
    public partial record SpecificationAttributeListModel : BasePagedListModel<SpecificationAttributeModel>
    {
    }
}