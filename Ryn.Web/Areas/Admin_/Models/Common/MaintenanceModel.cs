using System;
using System.ComponentModel.DataAnnotations;
using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    public partial record MaintenanceModel : BaseRynModel
    {
        public MaintenanceModel()
        {
            DeleteGuests = new DeleteGuestsModel();
            DeleteAbandonedCarts = new DeleteAbandonedCartsModel();
            DeleteExportedFiles = new DeleteExportedFilesModel();
            BackupFileSearchModel = new BackupFileSearchModel();
            DeleteAlreadySentQueuedEmails = new DeleteAlreadySentQueuedEmailsModel();
        }

        public DeleteGuestsModel DeleteGuests { get; set; }

        public DeleteAbandonedCartsModel DeleteAbandonedCarts { get; set; }

        public DeleteExportedFilesModel DeleteExportedFiles { get; set; }

        public BackupFileSearchModel BackupFileSearchModel { get; set; }

        public DeleteAlreadySentQueuedEmailsModel DeleteAlreadySentQueuedEmails { get; set; }

        public bool BackupSupported { get; set; }

        #region Nested classes

        public partial record DeleteGuestsModel : BaseRynModel
        {
            [RynResourceDisplayName("Admin.System.Maintenance.DeleteGuests.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [RynResourceDisplayName("Admin.System.Maintenance.DeleteGuests.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            [RynResourceDisplayName("Admin.System.Maintenance.DeleteGuests.OnlyWithoutShoppingCart")]
            public bool OnlyWithoutShoppingCart { get; set; }

            public int? NumberOfDeletedCustomers { get; set; }
        }

        public partial record DeleteAbandonedCartsModel : BaseRynModel
        {
            [RynResourceDisplayName("Admin.System.Maintenance.DeleteAbandonedCarts.OlderThan")]
            [UIHint("Date")]
            public DateTime OlderThan { get; set; }

            public int? NumberOfDeletedItems { get; set; }
        }

        public partial record DeleteExportedFilesModel : BaseRynModel
        {
            [RynResourceDisplayName("Admin.System.Maintenance.DeleteExportedFiles.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [RynResourceDisplayName("Admin.System.Maintenance.DeleteExportedFiles.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            public int? NumberOfDeletedFiles { get; set; }
        }

        public partial record DeleteAlreadySentQueuedEmailsModel : BaseRynModel
        {
            [RynResourceDisplayName("Admin.System.Maintenance.DeleteAlreadySentQueuedEmails.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [RynResourceDisplayName("Admin.System.Maintenance.DeleteAlreadySentQueuedEmails.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            public int? NumberOfDeletedEmails { get; set; }
        }

        #endregion
    }
}
