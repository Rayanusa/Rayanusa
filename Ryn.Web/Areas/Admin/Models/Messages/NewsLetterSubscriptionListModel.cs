﻿using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Messages
{
    /// <summary>
    /// Represents a newsletter subscription list model
    /// </summary>
    public partial record NewsletterSubscriptionListModel : BasePagedListModel<NewsletterSubscriptionModel>
    {
    }
}