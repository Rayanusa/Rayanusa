using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a plugin configuration model
    /// </summary>
    public partial record PluginConfigModel : BaseRynModel, IConfigModel
    {
        #region Properties

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Plugin.ClearPluginShadowDirectoryOnStartup")]
        public bool ClearPluginShadowDirectoryOnStartup { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Plugin.CopyLockedPluginAssembilesToSubdirectoriesOnStartup")]
        public bool CopyLockedPluginAssembilesToSubdirectoriesOnStartup { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Plugin.UseUnsafeLoadAssembly")]
        public bool UseUnsafeLoadAssembly { get; set; }

        [RynResourceDisplayName("Admin.Configuration.AppSettings.Plugin.UsePluginsShadowCopy")]
        public bool UsePluginsShadowCopy { get; set; }

        #endregion
    }
}