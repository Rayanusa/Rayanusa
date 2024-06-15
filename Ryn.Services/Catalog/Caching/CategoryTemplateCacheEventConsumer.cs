using System.Threading.Tasks;
using Ryn.Core.Domain.Catalog;
using Ryn.Services.Caching;

namespace Ryn.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a category template cache event consumer
    /// </summary>
    public partial class CategoryTemplateCacheEventConsumer : CacheEventConsumer<CategoryTemplate>
    {
    }
}
