using System;
using System.ComponentModel.DataAnnotations;
using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Logging
{
    /// <summary>
    /// Represents an activity log model
    /// </summary>
    public partial record ActivityLogModel : BaseRynEntityModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Customers.ActivityLog.Fields.ActivityLogType")]
        public string ActivityLogTypeName { get; set; }

        [RynResourceDisplayName("Admin.Customers.ActivityLog.Fields.Customer")]
        public int CustomerId { get; set; }

        [RynResourceDisplayName("Admin.Customers.ActivityLog.Fields.CustomerEmail")]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

        [RynResourceDisplayName("Admin.Customers.ActivityLog.Fields.Comment")]
        public string Comment { get; set; }

        [RynResourceDisplayName("Admin.Customers.ActivityLog.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [RynResourceDisplayName("Admin.Customers.ActivityLog.Fields.IpAddress")]
        public string IpAddress { get; set; }

        #endregion
    }
}