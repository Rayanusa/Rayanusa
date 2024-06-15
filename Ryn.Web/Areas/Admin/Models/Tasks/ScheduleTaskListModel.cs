﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Tasks
{
    /// <summary>
    /// Represents a schedule task list model
    /// </summary>
    public partial record ScheduleTaskListModel : BasePagedListModel<ScheduleTaskModel>
    {
    }
}