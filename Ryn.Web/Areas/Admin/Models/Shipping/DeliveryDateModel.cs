using System.Collections.Generic;
using Ryn.Web.Framework.Models;
using Ryn.Web.Framework.Mvc.ModelBinding;

namespace Ryn.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a delivery date model
    /// </summary>
    public partial record DeliveryDateModel : BaseRynEntityModel, ILocalizedModel<DeliveryDateLocalizedModel>
    {
        #region Ctor

        public DeliveryDateModel()
        {
            Locales = new List<DeliveryDateLocalizedModel>();
        }

        #endregion

        #region Properties

        [RynResourceDisplayName("Admin.Configuration.Shipping.DeliveryDates.Fields.Name")]
        public string Name { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Shipping.DeliveryDates.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<DeliveryDateLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial record DeliveryDateLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [RynResourceDisplayName("Admin.Configuration.Shipping.DeliveryDates.Fields.Name")]
        public string Name { get; set; }
    }
}