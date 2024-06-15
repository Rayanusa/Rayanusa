﻿using System.Threading.Tasks;
using Ryn.Core.Domain.Customers;
using Ryn.Services.Caching;
using Ryn.Services.Events;
using Ryn.Services.Orders;

namespace Ryn.Services.Customers.Caching
{
    /// <summary>
    /// Represents a customer cache event consumer
    /// </summary>
    public partial class CustomerCacheEventConsumer : CacheEventConsumer<Customer>, IConsumer<CustomerPasswordChangedEvent>
    {
        #region Methods

        /// <summary>
        /// Handle password changed event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        public async Task HandleEventAsync(CustomerPasswordChangedEvent eventMessage)
        {
            await RemoveAsync(RynCustomerServicesDefaults.CustomerPasswordLifetimeCacheKey, eventMessage.Password.CustomerId);
        }

        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        protected override async Task ClearCacheAsync(Customer entity)
        {
            await RemoveByPrefixAsync(RynCustomerServicesDefaults.CustomerCustomerRolesByCustomerPrefix, entity);
            await RemoveByPrefixAsync(RynCustomerServicesDefaults.CustomerAddressesByCustomerPrefix, entity);
            await RemoveByPrefixAsync(RynOrderDefaults.ShoppingCartItemsByCustomerPrefix, entity);
            await RemoveAsync(RynCustomerServicesDefaults.CustomerByGuidCacheKey, entity.CustomerGuid);

            if (string.IsNullOrEmpty(entity.SystemName))
                return;

            await RemoveAsync(RynCustomerServicesDefaults.CustomerBySystemNameCacheKey, entity.SystemName);
        }

        #endregion
    }
}