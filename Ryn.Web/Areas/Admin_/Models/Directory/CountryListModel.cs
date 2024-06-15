using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a country list model
    /// </summary>
    public partial record CountryListModel : BasePagedListModel<CountryModel>
    {
    }
}