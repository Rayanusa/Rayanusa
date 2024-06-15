using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer shopping cart search model
    /// </summary>
    public partial record CustomerShoppingCartSearchModel : BaseSearchModel
    {
        #region Ctor

        public CustomerShoppingCartSearchModel()
        {
            AvailableShoppingCartTypes = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public int CustomerId { get; set; }

        [RynResourceDisplayName("Admin.ShoppingCartType.ShoppingCartType")]
        public int ShoppingCartTypeId { get; set; }

        public IList<SelectListItem> AvailableShoppingCartTypes { get; set; }

        #endregion
    }
}