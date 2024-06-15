﻿using System.ComponentModel.DataAnnotations;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an upload license model
    /// </summary>
    public partial record UploadLicenseModel : BaseRynModel
    {
        #region Properties

        public int OrderId { get; set; }

        public int OrderItemId { get; set; }

        [UIHint("Download")]
        public int LicenseDownloadId { get; set; }

        #endregion
    }
}