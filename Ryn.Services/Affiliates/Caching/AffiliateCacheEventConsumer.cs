using Ryn.Core.Domain.Affiliates;
using Ryn.Services.Caching;

namespace Ryn.Services.Affiliates.Caching
{
    /// <summary>
    /// Represents an affiliate cache event consumer
    /// </summary>
    public partial class AffiliateCacheEventConsumer : CacheEventConsumer<Affiliate>
    {
    }
}
