using Ryn.Core.Domain.Messages;
using Ryn.Services.Caching;

namespace Ryn.Services.Messages.Caching
{
    /// <summary>
    /// Represents a campaign cache event consumer
    /// </summary>
    public partial class CampaignCacheEventConsumer : CacheEventConsumer<Campaign>
    {
    }
}
