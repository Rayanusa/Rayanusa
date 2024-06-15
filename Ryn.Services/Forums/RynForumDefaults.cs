using Ryn.Core.Caching;

namespace Ryn.Services.Forums
{
    /// <summary>
    /// Represents default values related to forums services
    /// </summary>
    public static partial class RynForumDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : forum group ID
        /// </remarks>
        public static CacheKey ForumByForumGroupCacheKey => new("Ryn.forum.byforumgroup.{0}");

        #endregion
    }
}