using System.Collections.Generic;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a product model to add to the discount
    /// </summary>
    public partial record AddProductToDiscountModel : BaseRynModel
    {
        #region Ctor

        public AddProductToDiscountModel()
        {
            SelectedProductIds = new List<int>();
        }
        #endregion

        #region Properties

        public int DiscountId { get; set; }

        public IList<int> SelectedProductIds { get; set; }

        #endregion
    }
}