// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Part of MultiTenantDiagnosticSettings. Specifies the settings for a
    /// particular metric.
    /// </summary>
    public partial class MetricSettings
    {
        /// <summary>
        /// Initializes a new instance of the MetricSettings class.
        /// </summary>
        public MetricSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSettings class.
        /// </summary>
        /// <param name="timeGrain">the timegrain of the metric in ISO8601
        /// format.</param>
        /// <param name="enabled">a value indicating whether this timegrain is
        /// enabled.</param>
        /// <param name="retentionPolicy">the retention policy for this
        /// timegrain.</param>
        public MetricSettings(System.TimeSpan timeGrain, bool enabled, RetentionPolicy retentionPolicy = default(RetentionPolicy))
        {
            TimeGrain = timeGrain;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the timegrain of the metric in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public System.TimeSpan TimeGrain { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this timegrain is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the retention policy for this timegrain.
        /// </summary>
        [JsonProperty(PropertyName = "retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RetentionPolicy != null)
            {
                RetentionPolicy.Validate();
            }
        }
    }
}
