using Ryn.Core.Domain.Media;
using Ryn.Services.Caching;

namespace Ryn.Services.Media.Caching
{
    /// <summary>
    /// Represents a download cache event consumer
    /// </summary>
    public partial class DownloadCacheEventConsumer : CacheEventConsumer<Download>
    {
    }
}
