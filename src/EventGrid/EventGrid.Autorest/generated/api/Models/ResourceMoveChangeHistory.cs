// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>The change history of the resource move.</summary>
    public partial class ResourceMoveChangeHistory :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceMoveChangeHistory,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceMoveChangeHistoryInternal
    {

        /// <summary>Backing field for <see cref="AzureSubscriptionId" /> property.</summary>
        private string _azureSubscriptionId;

        /// <summary>Azure subscription ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string AzureSubscriptionId { get => this._azureSubscriptionId; set => this._azureSubscriptionId = value; }

        /// <summary>Backing field for <see cref="ChangedTimeUtc" /> property.</summary>
        private global::System.DateTime? _changedTimeUtc;

        /// <summary>UTC timestamp of when the resource was changed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public global::System.DateTime? ChangedTimeUtc { get => this._changedTimeUtc; set => this._changedTimeUtc = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>Azure Resource Group of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Creates an new <see cref="ResourceMoveChangeHistory" /> instance.</summary>
        public ResourceMoveChangeHistory()
        {

        }
    }
    /// The change history of the resource move.
    public partial interface IResourceMoveChangeHistory :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>Azure subscription ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure subscription ID of the resource.",
        SerializedName = @"azureSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string AzureSubscriptionId { get; set; }
        /// <summary>UTC timestamp of when the resource was changed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"UTC timestamp of when the resource was changed.",
        SerializedName = @"changedTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ChangedTimeUtc { get; set; }
        /// <summary>Azure Resource Group of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure Resource Group of the resource.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }

    }
    /// The change history of the resource move.
    internal partial interface IResourceMoveChangeHistoryInternal

    {
        /// <summary>Azure subscription ID of the resource.</summary>
        string AzureSubscriptionId { get; set; }
        /// <summary>UTC timestamp of when the resource was changed.</summary>
        global::System.DateTime? ChangedTimeUtc { get; set; }
        /// <summary>Azure Resource Group of the resource.</summary>
        string ResourceGroupName { get; set; }

    }
}