using System.Threading.Tasks;
using Ryn.Core.Domain.Customers;
using Ryn.Services.Caching;

namespace Ryn.Services.Customers.Caching
{
    /// <summary>
    /// Represents a customer address mapping cache event consumer
    /// </summary>
    public partial class CustomerAddressMappingCacheEventConsumer : CacheEventConsumer<CustomerAddressMapping>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        protected override async Task ClearCacheAsync(CustomerAddressMapping entity)
        {
            await RemoveByPrefixAsync(RynCustomerServicesDefaults.CustomerAddressesPrefix);
        }
    }
}