using System.Threading.Tasks;
using Ryn.Core.Domain.Common;
using Ryn.Services.Caching;
using Ryn.Services.Customers;

namespace Ryn.Services.Common.Caching
{
    /// <summary>
    /// Represents a address cache event consumer
    /// </summary>
    public partial class AddressCacheEventConsumer : CacheEventConsumer<Address>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        protected override async Task ClearCacheAsync(Address entity)
        {
            await RemoveByPrefixAsync(RynCustomerServicesDefaults.CustomerAddressesPrefix);
        }
    }
}
