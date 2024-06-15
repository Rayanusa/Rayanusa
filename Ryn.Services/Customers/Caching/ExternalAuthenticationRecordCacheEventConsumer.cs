using Ryn.Core.Domain.Customers;
using Ryn.Services.Caching;

namespace Ryn.Services.Customers.Caching
{
    /// <summary>
    /// Represents an external authentication record cache event consumer
    /// </summary>
    public partial class ExternalAuthenticationRecordCacheEventConsumer : CacheEventConsumer<ExternalAuthenticationRecord>
    {
    }
}
