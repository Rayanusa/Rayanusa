﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a SEO settings model
    /// </summary>
    public partial record SeoSettingsModel : BaseRynModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.PageTitleSeparator")]
        public string PageTitleSeparator { get; set; }
        public bool PageTitleSeparator_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.PageTitleSeoAdjustment")]
        public int PageTitleSeoAdjustment { get; set; }
        public bool PageTitleSeoAdjustment_OverrideForStore { get; set; }
        public SelectList PageTitleSeoAdjustmentValues { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.HomepageTitle")]
        public string HomepageTitle { get; set; }
        public bool HomepageTitle_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.HomepageDescription")]
        public string HomepageDescription { get; set; }
        public bool HomepageDescription_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.DefaultTitle")]
        public string DefaultTitle { get; set; }
        public bool DefaultTitle_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.DefaultMetaKeywords")]
        public string DefaultMetaKeywords { get; set; }
        public bool DefaultMetaKeywords_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.DefaultMetaDescription")]
        public string DefaultMetaDescription { get; set; }
        public bool DefaultMetaDescription_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.GenerateProductMetaDescription")]
        public bool GenerateProductMetaDescription { get; set; }
        public bool GenerateProductMetaDescription_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.ConvertNonWesternChars")]
        public bool ConvertNonWesternChars { get; set; }
        public bool ConvertNonWesternChars_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CanonicalUrlsEnabled")]
        public bool CanonicalUrlsEnabled { get; set; }
        public bool CanonicalUrlsEnabled_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.WwwRequirement")]
        public int WwwRequirement { get; set; }
        public bool WwwRequirement_OverrideForStore { get; set; }
        public SelectList WwwRequirementValues { get; set; }        

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.TwitterMetaTags")]
        public bool TwitterMetaTags { get; set; }
        public bool TwitterMetaTags_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.OpenGraphMetaTags")]
        public bool OpenGraphMetaTags { get; set; }
        public bool OpenGraphMetaTags_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.CustomHeadTags")]
        public string CustomHeadTags { get; set; }
        public bool CustomHeadTags_OverrideForStore { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.Microdata")]
        public bool MicrodataEnabled { get; set; }
        public bool MicrodataEnabled_OverrideForStore { get; set; }
        #endregion
    }
}