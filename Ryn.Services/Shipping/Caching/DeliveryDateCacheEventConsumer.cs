using Ryn.Core.Domain.Shipping;
using Ryn.Services.Caching;
using System.Threading.Tasks;

namespace Ryn.Services.Shipping.Caching
{
    /// <summary>
    /// Represents a delivery date cache event consumer
    /// </summary>
    public partial class DeliveryDateCacheEventConsumer : CacheEventConsumer<DeliveryDate>
    {
    }
}