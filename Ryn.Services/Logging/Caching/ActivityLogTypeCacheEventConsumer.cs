using Ryn.Core.Domain.Logging;
using Ryn.Services.Caching;
using System.Threading.Tasks;

namespace Ryn.Services.Logging.Caching
{
    /// <summary>
    /// Represents a activity log type cache event consumer
    /// </summary>
    public partial class ActivityLogTypeCacheEventConsumer : CacheEventConsumer<ActivityLogType>
    {
    }
}
