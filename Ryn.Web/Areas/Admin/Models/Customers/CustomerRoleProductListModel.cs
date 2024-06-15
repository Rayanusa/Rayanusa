using Ryn.Web.Areas.Admin.Models.Catalog;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer role product list model
    /// </summary>
    public partial record CustomerRoleProductListModel : BasePagedListModel<ProductModel>
    {
    }
}