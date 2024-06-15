﻿using System;
using System.Collections.Generic;
using Ryn.Web.Framework.Mvc.ModelBinding;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Forums
{
    /// <summary>
    /// Represents a forum list model
    /// </summary>
    public partial record ForumModel : BaseRynEntityModel
    {
        #region Ctor

        public ForumModel()
        {
            ForumGroups = new List<ForumGroupModel>();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.ForumGroupId")]
        public int ForumGroupId { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.Name")]
        public string Name { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.Description")]
        public string Description { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        public List<ForumGroupModel> ForumGroups { get; set; }

        #endregion
    }
}