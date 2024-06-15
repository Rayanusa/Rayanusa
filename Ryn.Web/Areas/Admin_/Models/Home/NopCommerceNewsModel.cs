using System.Collections.Generic;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Home
{
    /// <summary>
    /// Represents a rynCommerce news model
    /// </summary>
    public partial record rynCommerceNewsModel : BaseRynModel
    {
        #region Ctor

        public rynCommerceNewsModel()
        {
            Items = new List<rynCommerceNewsDetailsModel>();
        }

        #endregion

        #region Properties

        public List<rynCommerceNewsDetailsModel> Items { get; set; }

        public bool HasNewItems { get; set; }

        public bool HideAdvertisements { get; set; }

        #endregion
    }
}