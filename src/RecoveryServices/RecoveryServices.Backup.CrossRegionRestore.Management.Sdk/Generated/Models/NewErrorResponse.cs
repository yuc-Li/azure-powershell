// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using System.Linq;

    /// <summary>
    /// The resource management error response.
    /// </summary>
    public partial class NewErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the NewErrorResponse class.
        /// </summary>
        public NewErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NewErrorResponse class.
        /// </summary>

        /// <param name="error">The error object.
        /// </param>
        public NewErrorResponse(NewErrorResponseError error = default(NewErrorResponseError))

        {
            this.Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the error object.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public NewErrorResponseError Error {get; set; }
    }
}