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
    using System.Linq;

    /// <summary>
    /// The integration account schema filter for odata query.
    /// </summary>
    public partial class IntegrationAccountSchemaFilterInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationAccountSchemaFilterInner class.
        /// </summary>
        public IntegrationAccountSchemaFilterInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationAccountSchemaFilterInner class.
        /// </summary>
        /// <param name="schemaType">The schema type of integration account
        /// schema. Possible values include: 'NotSpecified', 'Xml'</param>
        public IntegrationAccountSchemaFilterInner(SchemaType schemaType)
        {
            SchemaType = schemaType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the schema type of integration account schema.
        /// Possible values include: 'NotSpecified', 'Xml'
        /// </summary>
        [JsonProperty(PropertyName = "schemaType")]
        public SchemaType SchemaType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
