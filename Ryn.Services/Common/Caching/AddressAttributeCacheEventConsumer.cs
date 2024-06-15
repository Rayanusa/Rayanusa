﻿using System.Threading.Tasks;
using Ryn.Core.Domain.Common;
using Ryn.Services.Caching;

namespace Ryn.Services.Common.Caching
{
    /// <summary>
    /// Represents a address attribute cache event consumer
    /// </summary>
    public partial class AddressAttributeCacheEventConsumer : CacheEventConsumer<AddressAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        protected override async Task ClearCacheAsync(AddressAttribute entity)
        {
            await RemoveAsync(RynCommonDefaults.AddressAttributeValuesByAttributeCacheKey, entity);
        }
    }
}