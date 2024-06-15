using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ryn.Web.Areas.Admin.Factories;
using Ryn.Web.Framework.Components;

namespace Ryn.Web.Areas.Admin.Components
{
    /// <summary>
    /// Represents a view component that displays the rynCommerce news
    /// </summary>
    public class RynCommerceNewsViewComponent : RynViewComponent
    {
        #region Fields

        private readonly IHomeModelFactory _homeModelFactory;

        #endregion

        #region Ctor

        public RynCommerceNewsViewComponent(IHomeModelFactory homeModelFactory)
        {
            _homeModelFactory = homeModelFactory;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoke view component
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the view component result
        /// </returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            try
            {
                //prepare model
                var model = await _homeModelFactory.PrepareRynCommerceNewsModelAsync();

                return View(model);
            }
            catch
            {
                return Content(string.Empty);
            }
        }

        #endregion
    }
}