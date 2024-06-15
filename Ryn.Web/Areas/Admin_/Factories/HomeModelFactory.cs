using System;
using System.Linq;
using System.Threading.Tasks;
using Ryn.Core;
using Ryn.Core.Caching;
using Ryn.Core.Domain.Common;
using Ryn.Services.Common;
using Ryn.Services.Configuration;
using Ryn.Services.Logging;
using Ryn.Web.Areas.Admin.Infrastructure.Cache;
using Ryn.Web.Areas.Admin.Models.Home;

namespace Ryn.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the home models factory implementation
    /// </summary>
    public partial class HomeModelFactory : IHomeModelFactory
    {
        #region Fields

        private readonly AdminAreaSettings _adminAreaSettings;
        private readonly ICommonModelFactory _commonModelFactory;
        private readonly ILogger _logger;
        private readonly IOrderModelFactory _orderModelFactory;
        private readonly ISettingService _settingService;
        private readonly IStaticCacheManager _staticCacheManager;
        private readonly IWorkContext _workContext;
        private readonly NopHttpClient _nopHttpClient;

        #endregion

        #region Ctor

        public HomeModelFactory(AdminAreaSettings adminAreaSettings,
            ICommonModelFactory commonModelFactory,
            ILogger logger,
            IOrderModelFactory orderModelFactory,
            ISettingService settingService,
            IStaticCacheManager staticCacheManager,
            IWorkContext workContext,
            NopHttpClient nopHttpClient)
        {
            _adminAreaSettings = adminAreaSettings;
            _commonModelFactory = commonModelFactory;
            _logger = logger;
            _orderModelFactory = orderModelFactory;
            _settingService = settingService;
            _staticCacheManager = staticCacheManager;
            _workContext = workContext;
            _nopHttpClient = nopHttpClient;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prepare dashboard model
        /// </summary>
        /// <param name="model">Dashboard model</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the dashboard model
        /// </returns>
        public virtual async Task<DashboardModel> PrepareDashboardModelAsync(DashboardModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            model.IsLoggedInAsVendor = await _workContext.GetCurrentVendorAsync() != null;

            //prepare nested search models
            await _commonModelFactory.PreparePopularSearchTermSearchModelAsync(model.PopularSearchTerms);
            await _orderModelFactory.PrepareBestsellerBriefSearchModelAsync(model.BestsellersByAmount);
            await _orderModelFactory.PrepareBestsellerBriefSearchModelAsync(model.BestsellersByQuantity);

            return model;
        }

        /// <summary>
        /// Prepare rynCommerce news model
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the rynCommerce news model
        /// </returns>
        public virtual async Task<rynCommerceNewsModel> PreparerynCommerceNewsModelAsync()
        {
            var model = new rynCommerceNewsModel
            {
                HideAdvertisements = _adminAreaSettings.HideAdvertisementsOnAdminArea
            };

            try
            {
                //try to get news RSS feed
                var rssData = await _staticCacheManager.GetAsync(_staticCacheManager.PrepareKeyForDefaultCache(RynModelCacheDefaults.OfficialNewsModelKey), async () =>
                {
                    try
                    {
                        return await _nopHttpClient.GetNewsRssAsync();
                    }
                    catch (AggregateException exception)
                    {
                        //rethrow actual excepion
                        throw exception.InnerException;
                    }
                });

                for (var i = 0; i < rssData.Items.Count; i++)
                {
                    var item = rssData.Items.ElementAt(i);
                    var newsItem = new rynCommerceNewsDetailsModel
                    {
                        Title = item.TitleText,
                        Summary = XmlHelper.XmlDecode(item.Content?.Value ?? string.Empty),
                        Url = item.Url.OriginalString,
                        PublishDate = item.PublishDate
                    };
                    model.Items.Add(newsItem);

                    //has new items?
                    if (i != 0)
                        continue;

                    var firstRequest = string.IsNullOrEmpty(_adminAreaSettings.LastNewsTitleAdminArea);
                    if (_adminAreaSettings.LastNewsTitleAdminArea == newsItem.Title)
                        continue;

                    _adminAreaSettings.LastNewsTitleAdminArea = newsItem.Title;
                    await _settingService.SaveSettingAsync(_adminAreaSettings);

                    //new item
                    if (!firstRequest)
                        model.HasNewItems = true;
                }
            }
            catch (Exception ex)
            {
                await _logger.ErrorAsync("No access to the news. Website www.rynCommerce.com is not available.", ex);
            }

            return model;
        }

        #endregion
    }
}