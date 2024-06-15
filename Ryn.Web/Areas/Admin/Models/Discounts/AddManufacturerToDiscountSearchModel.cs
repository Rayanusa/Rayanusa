using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a manufacturer search model to add to the discount
    /// </summary>
    public partial record AddManufacturerToDiscountSearchModel : BaseSearchModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Catalog.Manufacturers.List.SearchManufacturerName")]
        public string SearchManufacturerName { get; set; }

        #endregion
    }
}