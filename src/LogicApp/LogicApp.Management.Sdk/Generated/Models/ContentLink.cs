// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System.Linq;

    /// <summary>
    /// The content link.
    /// </summary>
    public partial class ContentLink
    {
        /// <summary>
        /// Initializes a new instance of the ContentLink class.
        /// </summary>
        public ContentLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentLink class.
        /// </summary>

        /// <param name="uri">The content link URI.
        /// </param>

        /// <param name="contentVersion">The content version.
        /// </param>

        /// <param name="contentSize">The content size.
        /// </param>

        /// <param name="contentHash">The content hash.
        /// </param>

        /// <param name="metadata">The metadata.
        /// </param>
        public ContentLink(string uri = default(string), string contentVersion = default(string), long? contentSize = default(long?), ContentHash contentHash = default(ContentHash), object metadata = default(object))

        {
            this.Uri = uri;
            this.ContentVersion = contentVersion;
            this.ContentSize = contentSize;
            this.ContentHash = contentHash;
            this.Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the content link URI.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uri")]
        public string Uri {get; set; }

        /// <summary>
        /// Gets or sets the content version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "contentVersion")]
        public string ContentVersion {get; set; }

        /// <summary>
        /// Gets or sets the content size.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "contentSize")]
        public long? ContentSize {get; set; }

        /// <summary>
        /// Gets or sets the content hash.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "contentHash")]
        public ContentHash ContentHash {get; set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public object Metadata {get; set; }
    }
}