﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Polls
{
    /// <summary>
    /// Represents a poll model
    /// </summary>
    public partial record PollModel : BaseRynEntityModel, IStoreMappingSupportedModel
    {
        #region Ctor

        public PollModel()
        {
            AvailableLanguages = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
            SelectedStoreIds = new List<int>();
            PollAnswerSearchModel = new PollAnswerSearchModel();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.Language")]
        public int LanguageId { get; set; }

        public IList<SelectListItem> AvailableLanguages { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.Language")]
        public string LanguageName { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.Name")]
        public string Name { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.SystemKeyword")]
        public string SystemKeyword { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.Published")]
        public bool Published { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.ShowOnHomepage")]
        public bool ShowOnHomepage { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.AllowGuestsToVote")]
        public bool AllowGuestsToVote { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.StartDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? StartDateUtc { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.EndDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? EndDateUtc { get; set; }

        [RynResourceDisplayName("Admin.ContentManagement.Polls.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public PollAnswerSearchModel PollAnswerSearchModel { get; set; }

        #endregion
    }
}