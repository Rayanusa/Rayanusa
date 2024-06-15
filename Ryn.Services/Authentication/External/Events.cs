﻿using Ryn.Core.Domain.Customers;

namespace Ryn.Services.Authentication.External
{
    /// <summary>
    /// Customer auto registered by external authentication method event
    /// </summary>
    public class CustomerAutoRegisteredByExternalMethodEvent
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="customer">Customer</param>
        /// <param name="parameters">Parameters</param>
        public CustomerAutoRegisteredByExternalMethodEvent(Customer customer, ExternalAuthenticationParameters parameters)
        {
            Customer = customer;
            AuthenticationParameters = parameters;
        }

        /// <summary>
        /// Gets or sets customer
        /// </summary>
        public Customer Customer { get; }

        /// <summary>
        /// Gets or sets external authentication parameters
        /// </summary>
        public ExternalAuthenticationParameters AuthenticationParameters { get; }
    }
}