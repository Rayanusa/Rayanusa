using Ryn.Core.Domain.Orders;
using Ryn.Services.Caching;
using System.Threading.Tasks;

namespace Ryn.Services.Orders.Caching
{
    /// <summary>
    /// Represents a checkout attribute cache event consumer
    /// </summary>
    public partial class CheckoutAttributeCacheEventConsumer : CacheEventConsumer<CheckoutAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        protected override async Task ClearCacheAsync(CheckoutAttribute entity)
        {
            await RemoveAsync(RynOrderDefaults.CheckoutAttributeValuesAllCacheKey, entity);
        }
    }
}
