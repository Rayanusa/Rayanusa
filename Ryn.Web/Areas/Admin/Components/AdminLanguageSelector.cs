﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ryn.Web.Areas.Admin.Factories;
using Ryn.Web.Framework.Components;

namespace Ryn.Web.Areas.Admin.Components
{
    /// <summary>
    /// Represents a view component that displays the admin language selector
    /// </summary>
    public class AdminLanguageSelectorViewComponent : RynViewComponent
    {
        #region Fields

        private readonly ICommonModelFactory _commonModelFactory;

        #endregion

        #region Ctor

        public AdminLanguageSelectorViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
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
            //prepare model
            var model = await _commonModelFactory.PrepareLanguageSelectorModelAsync();

            return View(model);
        }

        #endregion
    }
}