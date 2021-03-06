// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The B2B partner content.
    /// </summary>
    public partial class B2BPartnerContent
    {
        /// <summary>
        /// Initializes a new instance of the B2BPartnerContent class.
        /// </summary>
        public B2BPartnerContent()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the B2BPartnerContent class.
        /// </summary>
        /// <param name="businessIdentities">The list of partner business
        /// identities.</param>
        public B2BPartnerContent(IList<BusinessIdentity> businessIdentities = default(IList<BusinessIdentity>))
        {
            BusinessIdentities = businessIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of partner business identities.
        /// </summary>
        [JsonProperty(PropertyName = "businessIdentities")]
        public IList<BusinessIdentity> BusinessIdentities { get; set; }

    }
}
