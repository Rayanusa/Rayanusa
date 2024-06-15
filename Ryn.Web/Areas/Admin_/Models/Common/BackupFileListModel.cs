using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents a backup file list model
    /// </summary>
    public partial record BackupFileListModel : BasePagedListModel<BackupFileModel>
    {
    }
}