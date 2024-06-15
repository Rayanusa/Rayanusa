using Ryn.Core.Domain.Orders;
using Ryn.Services.Caching;

namespace Ryn.Services.Orders.Caching
{
    /// <summary>
    /// Represents a gift card cache event consumer
    /// </summary>
    public partial class GiftCardCacheEventConsumer : CacheEventConsumer<GiftCard>
    {
    }
}
