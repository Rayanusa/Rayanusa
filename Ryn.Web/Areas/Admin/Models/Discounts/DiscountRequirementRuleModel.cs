﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount requirement rule model
    /// </summary>
    public partial record DiscountRequirementRuleModel : BaseRynModel
    {
        #region Ctor

        public DiscountRequirementRuleModel()
        {
            ChildRequirements = new List<DiscountRequirementRuleModel>();
        }

        #endregion

        #region Properties

        public int DiscountRequirementId { get; set; }

        public string RuleName { get; set; }

        public string ConfigurationUrl { get; set; }

        public string InteractionType { get; set; }

        public int? ParentId { get; set; }

        public SelectList AvailableInteractionTypes { get; set; }

        public bool IsGroup { get; set; }

        public bool IsLastInGroup { get; set; }

        public IList<DiscountRequirementRuleModel> ChildRequirements { get; set; }

        #endregion
    }
}