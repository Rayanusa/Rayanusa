using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product attribute value search model
    /// </summary>
    public partial record ProductAttributeValueSearchModel : BaseSearchModel
    {
        #region Properties

        public int ProductAttributeMappingId { get; set; }

        #endregion
    }
}