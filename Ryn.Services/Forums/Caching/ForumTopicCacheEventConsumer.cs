using Ryn.Core.Domain.Forums;
using Ryn.Services.Caching;

namespace Ryn.Services.Forums.Caching
{
    /// <summary>
    /// Represents a forum topic cache event consumer
    /// </summary>
    public partial class ForumTopicCacheEventConsumer : CacheEventConsumer<ForumTopic>
    {
    }
}
