using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Templates
{
    /// <summary>
    /// Represents a product template list model
    /// </summary>
    public partial record ProductTemplateListModel : BasePagedListModel<ProductTemplateModel>
    {
    }
}