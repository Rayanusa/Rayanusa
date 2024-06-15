using Ryn.Core.Caching;
using Ryn.Core.Domain.Configuration;

namespace Ryn.Services.Configuration
{
    /// <summary>
    /// Represents default values related to settings
    /// </summary>
    public static partial class RynSettingsDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey SettingsAllAsDictionaryCacheKey => new("Ryn.setting.all.dictionary.", RynEntityCacheDefaults<Setting>.Prefix);

        #endregion
    }
}