using Ryn.Core.Domain.Logging;
using Ryn.Services.Caching;

namespace Ryn.Services.Logging.Caching
{
    /// <summary>
    /// Represents an activity log cache event consumer
    /// </summary>
    public partial class ActivityLogCacheEventConsumer : CacheEventConsumer<ActivityLog>
    {
    }
}