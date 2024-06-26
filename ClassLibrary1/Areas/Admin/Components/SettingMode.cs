﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ryn.Web.Areas.Admin.Factories;
using Ryn.Web.Framework.Components;

namespace Ryn.Web.Areas.Admin.Components
{
    /// <summary>
    /// Represents a view component that displays the setting mode
    /// </summary>
    public class SettingModeViewComponent : RynViewComponent
    {
        #region Fields

        private readonly ISettingModelFactory _settingModelFactory;

        #endregion

        #region Ctor

        public SettingModeViewComponent(ISettingModelFactory settingModelFactory)
        {
            _settingModelFactory = settingModelFactory;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoke view component
        /// </summary>
        /// <param name="modeName">Setting mode name</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the view component result
        /// </returns>
        public async Task<IViewComponentResult> InvokeAsync(string modeName = "settings-advanced-mode")
        {
            //prepare model
            var model = await _settingModelFactory.PrepareSettingModeModelAsync(modeName);

            return View(model);
        }

        #endregion
    }
}