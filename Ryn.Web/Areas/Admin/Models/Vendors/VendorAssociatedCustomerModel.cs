using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor associated customer model
    /// </summary>
    public partial record VendorAssociatedCustomerModel : BaseRynEntityModel
    {
        #region Properties

        public string Email { get; set; }

        #endregion
    }
}