using Ryn.Core.Caching;
using Ryn.Core.Domain.Discounts;

namespace Ryn.Services.Discounts
{
    /// <summary>
    /// Represents default values related to discounts services
    /// </summary>
    public static partial class RynDiscountDefaults
    {
        /// <summary>
        /// Gets the query parameter name to retrieve discount coupon code from URL
        /// </summary>
        public static string DiscountCouponQueryParameter => "discountcoupon";

        #region Caching defaults

        /// <summary>
        /// Key for discount requirement of a certain discount
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// </remarks>
        public static CacheKey DiscountRequirementsByDiscountCacheKey => new("Ryn.discountrequirement.bydiscount.{0}");

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// {1} : coupon code
        /// {2} : discount name
        /// </remarks>
        public static CacheKey DiscountAllCacheKey => new("Ryn.discount.all.{0}-{1}-{2}", RynEntityCacheDefaults<Discount>.AllPrefix);

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} - entity type
        /// {1} - entity id
        /// </remarks>
        public static CacheKey AppliedDiscountsCacheKey => new("Ryn.discount.applied.{0}-{1}", AppliedDiscountsCachePrefix);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string AppliedDiscountsCachePrefix => "Ryn.discount.applied.";

        /// <summary>
        /// Key for category IDs of a discount
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// {1} : roles of the current user
        /// {2} : current store ID
        /// </remarks>
        public static CacheKey CategoryIdsByDiscountCacheKey => new("Ryn.discount.categoryids.bydiscount.{0}-{1}-{2}", CategoryIdsByDiscountPrefix, CategoryIdsPrefix);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// </remarks>
        public static string CategoryIdsByDiscountPrefix => "Ryn.discount.categoryids.bydiscount.{0}";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string CategoryIdsPrefix => "Ryn.discount.categoryids.bydiscount.";

        /// <summary>
        /// Key for manufacturer IDs of a discount
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// {1} : roles of the current user
        /// {2} : current store ID
        /// </remarks>
        public static CacheKey ManufacturerIdsByDiscountCacheKey => new("Ryn.discount.manufacturerids.bydiscount.{0}-{1}-{2}", ManufacturerIdsByDiscountPrefix, ManufacturerIdsPrefix);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// </remarks>
        public static string ManufacturerIdsByDiscountPrefix => "Ryn.discount.manufacturerids.bydiscount.{0}";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ManufacturerIdsPrefix => "Ryn.discount.manufacturerids.bydiscount.";

        #endregion
    }
}