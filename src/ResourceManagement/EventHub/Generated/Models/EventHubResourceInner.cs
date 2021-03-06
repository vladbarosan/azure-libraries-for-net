// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.EventHub;
    using Microsoft.Azure.Management.EventHub.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single item in List or Get Event Hub operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EventHubResourceInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the EventHubResourceInner class.
        /// </summary>
        public EventHubResourceInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventHubResourceInner class.
        /// </summary>
        /// <param name="createdAt">Exact time the Event Hub was
        /// created.</param>
        /// <param name="messageRetentionInDays">Number of days to retain the
        /// events for this Event Hub.</param>
        /// <param name="partitionCount">Number of partitions created for the
        /// Event Hub.</param>
        /// <param name="partitionIds">Current number of shards on the Event
        /// Hub.</param>
        /// <param name="status">Enumerates the possible values for the status
        /// of the Event Hub. Possible values include: 'Active', 'Disabled',
        /// 'Restoring', 'SendDisabled', 'ReceiveDisabled', 'Creating',
        /// 'Deleting', 'Renaming', 'Unknown'</param>
        /// <param name="updatedAt">The exact time the message was
        /// updated.</param>
        public EventHubResourceInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? createdAt = default(System.DateTime?), long? messageRetentionInDays = default(long?), long? partitionCount = default(long?), IList<string> partitionIds = default(IList<string>), EntityStatus? status = default(EntityStatus?), System.DateTime? updatedAt = default(System.DateTime?))
            : base(location, id, name, type, tags)
        {
            CreatedAt = createdAt;
            MessageRetentionInDays = messageRetentionInDays;
            PartitionCount = partitionCount;
            PartitionIds = partitionIds;
            Status = status;
            UpdatedAt = updatedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets exact time the Event Hub was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets or sets number of days to retain the events for this Event
        /// Hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.messageRetentionInDays")]
        public long? MessageRetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets number of partitions created for the Event Hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partitionCount")]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// Gets current number of shards on the Event Hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partitionIds")]
        public IList<string> PartitionIds { get; private set; }

        /// <summary>
        /// Gets or sets enumerates the possible values for the status of the
        /// Event Hub. Possible values include: 'Active', 'Disabled',
        /// 'Restoring', 'SendDisabled', 'ReceiveDisabled', 'Creating',
        /// 'Deleting', 'Renaming', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public EntityStatus? Status { get; set; }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

    }
}
