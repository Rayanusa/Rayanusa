﻿using System.Collections.Generic;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer attribute value model
    /// </summary>
    public partial record CustomerAttributeValueModel : BaseRynEntityModel, ILocalizedModel<CustomerAttributeValueLocalizedModel>
    {
        #region Ctor

        public CustomerAttributeValueModel()
        {
            Locales = new List<CustomerAttributeValueLocalizedModel>();
        }

        #endregion

        #region Properties

        public int CustomerAttributeId { get; set; }

        [RynResourceDisplayName("Admin.Customers.CustomerAttributes.Values.Fields.Name")]
        public string Name { get; set; }

        [RynResourceDisplayName("Admin.Customers.CustomerAttributes.Values.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [RynResourceDisplayName("Admin.Customers.CustomerAttributes.Values.Fields.DisplayOrder")]
        public int DisplayOrder {get;set;}

        public IList<CustomerAttributeValueLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial record CustomerAttributeValueLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [RynResourceDisplayName("Admin.Customers.CustomerAttributes.Values.Fields.Name")]
        public string Name { get; set; }
    }
}