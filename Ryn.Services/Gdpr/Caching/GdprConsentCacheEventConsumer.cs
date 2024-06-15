using System.Threading.Tasks;
using Ryn.Core.Domain.Gdpr;
using Ryn.Services.Caching;

namespace Ryn.Services.Gdpr.Caching
{
    /// <summary>
    /// Represents a GDPR consent cache event consumer
    /// </summary>
    public partial class GdprConsentCacheEventConsumer : CacheEventConsumer<GdprConsent>
    {
    }
}