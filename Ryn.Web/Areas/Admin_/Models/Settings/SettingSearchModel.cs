using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a setting search model
    /// </summary>
    public partial record SettingSearchModel : BaseSearchModel
    {
        #region Ctor

        public SettingSearchModel()
        {
            AddSetting = new SettingModel();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.Configuration.Settings.AllSettings.SearchSettingName")]
        public string SearchSettingName { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Settings.AllSettings.SearchSettingValue")]
        public string SearchSettingValue { get; set; }

        public SettingModel AddSetting { get; set; }

        #endregion
    }
}