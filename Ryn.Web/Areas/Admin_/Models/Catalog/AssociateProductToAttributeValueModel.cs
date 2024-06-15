using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product model to associate to the product attribute value
    /// </summary>
    public partial record AssociateProductToAttributeValueModel : BaseRynModel
    {
        #region Properties
        
        public int AssociatedToProductId { get; set; }

        #endregion
    }
}