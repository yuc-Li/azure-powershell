// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// A description of the scaling capacities of the SKU
    /// </summary>
    public partial class AvailableServiceSkuCapacity
    {
        /// <summary>
        /// Initializes a new instance of the AvailableServiceSkuCapacity class.
        /// </summary>
        public AvailableServiceSkuCapacity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableServiceSkuCapacity class.
        /// </summary>

        /// <param name="minimum">The minimum capacity, usually 0 or 1.
        /// </param>

        /// <param name="maximum">The maximum capacity
        /// </param>

        /// <param name="defaultProperty">The default capacity
        /// </param>

        /// <param name="scaleType">The scalability approach
        /// Possible values include: &#39;none&#39;, &#39;manual&#39;, &#39;automatic&#39;</param>
        public AvailableServiceSkuCapacity(int? minimum = default(int?), int? maximum = default(int?), int? defaultProperty = default(int?), string scaleType = default(string))

        {
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.DefaultProperty = defaultProperty;
            this.ScaleType = scaleType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the minimum capacity, usually 0 or 1.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minimum")]
        public int? Minimum {get; set; }

        /// <summary>
        /// Gets or sets the maximum capacity
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maximum")]
        public int? Maximum {get; set; }

        /// <summary>
        /// Gets or sets the default capacity
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "default")]
        public int? DefaultProperty {get; set; }

        /// <summary>
        /// Gets or sets the scalability approach Possible values include: &#39;none&#39;, &#39;manual&#39;, &#39;automatic&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scaleType")]
        public string ScaleType {get; set; }
    }
}