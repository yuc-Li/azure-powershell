// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.PowerShell;

    /// <summary>
    /// See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity
    /// integration.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterPodIdentityProfileTypeConverter))]
    public partial class ManagedClusterPodIdentityProfile
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPodIdentityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfile"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedClusterPodIdentityProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPodIdentityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfile"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedClusterPodIdentityProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedClusterPodIdentityProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedClusterPodIdentityProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPodIdentityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedClusterPodIdentityProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AllowNetworkPluginKubenet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).AllowNetworkPluginKubenet = (bool?) content.GetValueForProperty("AllowNetworkPluginKubenet",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).AllowNetworkPluginKubenet, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).UserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentity[]) content.GetValueForProperty("UserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).UserAssignedIdentity, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentity>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPodIdentityTypeConverter.ConvertFrom));
            }
            if (content.Contains("UserAssignedIdentityException"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).UserAssignedIdentityException = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityException[]) content.GetValueForProperty("UserAssignedIdentityException",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).UserAssignedIdentityException, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityException>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPodIdentityExceptionTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPodIdentityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedClusterPodIdentityProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AllowNetworkPluginKubenet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).AllowNetworkPluginKubenet = (bool?) content.GetValueForProperty("AllowNetworkPluginKubenet",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).AllowNetworkPluginKubenet, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).UserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentity[]) content.GetValueForProperty("UserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).UserAssignedIdentity, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentity>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPodIdentityTypeConverter.ConvertFrom));
            }
            if (content.Contains("UserAssignedIdentityException"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).UserAssignedIdentityException = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityException[]) content.GetValueForProperty("UserAssignedIdentityException",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityProfileInternal)this).UserAssignedIdentityException, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPodIdentityException>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPodIdentityExceptionTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity
    /// integration.
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterPodIdentityProfileTypeConverter))]
    public partial interface IManagedClusterPodIdentityProfile

    {

    }
}