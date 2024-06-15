using Ryn.Core.Domain.Catalog;
using Ryn.Services.Caching;

namespace Ryn.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a back in stock subscription cache event consumer
    /// </summary>
    public partial class BackInStockSubscriptionCacheEventConsumer : CacheEventConsumer<BackInStockSubscription>
    {
    }
}
