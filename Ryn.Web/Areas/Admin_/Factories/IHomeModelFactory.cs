using System.Threading.Tasks;
using Ryn.Web.Areas.Admin.Models.Home;

namespace Ryn.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the home models factory
    /// </summary>
    public partial interface IHomeModelFactory
    {
        /// <summary>
        /// Prepare dashboard model
        /// </summary>
        /// <param name="model">Dashboard model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the dashboard model
        /// </returns>
        Task<DashboardModel> PrepareDashboardModelAsync(DashboardModel model);

        /// <summary>
        /// Prepare rynCommerce news model
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the rynCommerce news model
        /// </returns>
        Task<rynCommerceNewsModel> PreparerynCommerceNewsModelAsync();
    }
}