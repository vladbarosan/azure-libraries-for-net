// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Reponse body for generating an upload URI.
    /// </summary>
    public partial class GenerateUploadUriResponseInner
    {
        /// <summary>
        /// Initializes a new instance of the GenerateUploadUriResponseInner
        /// class.
        /// </summary>
        public GenerateUploadUriResponseInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenerateUploadUriResponseInner
        /// class.
        /// </summary>
        /// <param name="uploadUri">The upload URI for the VHD.</param>
        public GenerateUploadUriResponseInner(string uploadUri = default(string))
        {
            UploadUri = uploadUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the upload URI for the VHD.
        /// </summary>
        [JsonProperty(PropertyName = "uploadUri")]
        public string UploadUri { get; set; }

    }
}
