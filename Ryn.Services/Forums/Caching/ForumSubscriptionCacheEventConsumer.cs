using Ryn.Core.Domain.Forums;
using Ryn.Services.Caching;

namespace Ryn.Services.Forums.Caching
{
    /// <summary>
    /// Represents a forum subscription cache event consumer
    /// </summary>
    public partial class ForumSubscriptionCacheEventConsumer : CacheEventConsumer<ForumSubscription>
    {
    }
}
