using Ryn.Core.Domain.Gdpr;
using Ryn.Services.Caching;

namespace Ryn.Services.Gdpr.Caching
{
    /// <summary>
    /// Represents a GDPR log cache event consumer
    /// </summary>
    public partial class GdprLogCacheEventConsumer : CacheEventConsumer<GdprLog>
    {
    }
}
