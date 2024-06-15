using System;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Home
{
    /// <summary>
    /// Represents a rynCommerce news details model
    /// </summary>
    public partial record rynCommerceNewsDetailsModel : BaseRynModel
    {
        #region Properties

        public string Title { get; set; }

        public string Url { get; set; }

        public string Summary { get; set; }

        public DateTimeOffset PublishDate { get; set; }

        #endregion
    }
}