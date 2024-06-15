using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Templates
{
    /// <summary>
    /// Represents a category template list model
    /// </summary>
    public partial record CategoryTemplateListModel : BasePagedListModel<CategoryTemplateModel>
    {
    }
}