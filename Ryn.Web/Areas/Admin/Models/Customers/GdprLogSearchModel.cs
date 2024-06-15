using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a GDPR log search model
    /// </summary>
    public partial record GdprLogSearchModel : BaseSearchModel
    {
        #region Ctor

        public GdprLogSearchModel()
        {
            AvailableRequestTypes = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.Customers.GdprLog.List.SearchEmail")]
        [DataType(DataType.EmailAddress)]
        public string SearchEmail { get; set; }

        [RynResourceDisplayName("Admin.Customers.GdprLog.List.SearchRequestType")]
        public int SearchRequestTypeId { get; set; }

        public IList<SelectListItem> AvailableRequestTypes { get; set; }

        #endregion
    }
}