using Ryn.Core.Domain.Forums;
using Ryn.Services.Caching;

namespace Ryn.Services.Forums.Caching
{
    /// <summary>
    /// Represents a forum post cache event consumer
    /// </summary>
    public partial class ForumPostCacheEventConsumer : CacheEventConsumer<ForumPost>
    {
    }
}
