using System.Threading.Tasks;
using Ryn.Core.Domain.Directory;
using Ryn.Services.Caching;

namespace Ryn.Services.Directory.Caching
{
    /// <summary>
    /// Represents a currency cache event consumer
    /// </summary>
    public partial class CurrencyCacheEventConsumer : CacheEventConsumer<Currency>
    {
    }
}
