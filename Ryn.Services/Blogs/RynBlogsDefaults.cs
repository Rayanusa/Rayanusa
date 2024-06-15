using Ryn.Core.Caching;

namespace Ryn.Services.Blogs
{
    /// <summary>
    /// Represents default values related to blogs services
    /// </summary>
    public static partial class RynBlogsDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Key for number of blog comments
        /// </summary>
        /// <remarks>
        /// {0} : blog post ID
        /// {1} : store ID
        /// {2} : are only approved comments?
        /// </remarks>
        public static CacheKey BlogCommentsNumberCacheKey => new("Ryn.blogcomment.number.{0}-{1}-{2}", BlogCommentsNumberPrefix);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : blog post ID
        /// </remarks>
        public static string BlogCommentsNumberPrefix => "Ryn.blogcomment.number.{0}";

        /// <summary>
        /// Key for blog tag list model
        /// </summary>
        /// <remarks>
        /// {0} : language ID
        /// {1} : current store ID
        /// {2} : show hidden?
        /// </remarks>
        public static CacheKey BlogTagsCacheKey => new("Ryn.blogpost.tags.{0}-{1}-{2}", BlogTagsPrefix);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string BlogTagsPrefix => "Ryn.blogpost.tags.";

        #endregion
    }
}