using Ryn.Core.Domain.Messages;
using Ryn.Services.Caching;
using System.Threading.Tasks;

namespace Ryn.Services.Messages.Caching
{
    /// <summary>
    /// Represents an email account cache event consumer
    /// </summary>
    public partial class EmailAccountCacheEventConsumer : CacheEventConsumer<EmailAccount>
    {
    }
}
