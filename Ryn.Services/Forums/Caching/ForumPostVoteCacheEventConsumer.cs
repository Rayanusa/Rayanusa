using Ryn.Core.Domain.Forums;
using Ryn.Services.Caching;

namespace Ryn.Services.Forums.Caching
{
    /// <summary>
    /// Represents a forum post vote cache event consumer
    /// </summary>
    public partial class ForumPostVoteCacheEventConsumer : CacheEventConsumer<ForumPostVote>
    {
    }
}
