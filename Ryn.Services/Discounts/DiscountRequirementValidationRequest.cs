﻿using Ryn.Core.Domain.Customers;
using Ryn.Core.Domain.Stores;

namespace Ryn.Services.Discounts
{
    /// <summary>
    /// Represents a request of discount requirement validation
    /// </summary>
    public partial class DiscountRequirementValidationRequest
    {
        /// <summary>
        /// Gets or sets the appropriate discount requirement ID (identifier)
        /// </summary>
        public int DiscountRequirementId { get; set; }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the store
        /// </summary>
        public Store Store { get; set; }
    }
}
