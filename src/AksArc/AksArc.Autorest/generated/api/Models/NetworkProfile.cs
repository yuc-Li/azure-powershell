// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Extensions;

    /// <summary>The network configuration profile for the provisioned cluster.</summary>
    public partial class NetworkProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.INetworkProfile,
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.INetworkProfileInternal
    {

        /// <summary>Backing field for <see cref="LoadBalancerProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.INetworkProfileLoadBalancerProfile _loadBalancerProfile;

        /// <summary>Profile of the HA Proxy load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.INetworkProfileLoadBalancerProfile LoadBalancerProfile { get => (this._loadBalancerProfile = this._loadBalancerProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.NetworkProfileLoadBalancerProfile()); set => this._loadBalancerProfile = value; }

        /// <summary>Number of HA Proxy load balancer VMs. The default value is 0.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public int? LoadBalancerProfileCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.INetworkProfileLoadBalancerProfileInternal)LoadBalancerProfile).Count; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.INetworkProfileLoadBalancerProfileInternal)LoadBalancerProfile).Count = value ?? default(int); }

        /// <summary>Internal Acessors for LoadBalancerProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.INetworkProfileLoadBalancerProfile Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.INetworkProfileInternal.LoadBalancerProfile { get => (this._loadBalancerProfile = this._loadBalancerProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.NetworkProfileLoadBalancerProfile()); set { {_loadBalancerProfile = value;} } }

        /// <summary>Backing field for <see cref="NetworkPolicy" /> property.</summary>
        private string _networkPolicy;

        /// <summary>
        /// Network policy used for building Kubernetes network. Possible values include: 'calico'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string NetworkPolicy { get => this._networkPolicy; set => this._networkPolicy = value; }

        /// <summary>Backing field for <see cref="PodCidr" /> property.</summary>
        private string _podCidr;

        /// <summary>A CIDR notation IP Address range from which to assign pod IPs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string PodCidr { get => this._podCidr; set => this._podCidr = value; }

        /// <summary>Creates an new <see cref="NetworkProfile" /> instance.</summary>
        public NetworkProfile()
        {

        }
    }
    /// The network configuration profile for the provisioned cluster.
    public partial interface INetworkProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IJsonSerializable
    {
        /// <summary>Number of HA Proxy load balancer VMs. The default value is 0.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of HA Proxy load balancer VMs. The default value is 0.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? LoadBalancerProfileCount { get; set; }
        /// <summary>
        /// Network policy used for building Kubernetes network. Possible values include: 'calico'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Network policy used for building Kubernetes network. Possible values include: 'calico'.",
        SerializedName = @"networkPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("calico")]
        string NetworkPolicy { get; set; }
        /// <summary>A CIDR notation IP Address range from which to assign pod IPs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A CIDR notation IP Address range from which to assign pod IPs.",
        SerializedName = @"podCidr",
        PossibleTypes = new [] { typeof(string) })]
        string PodCidr { get; set; }

    }
    /// The network configuration profile for the provisioned cluster.
    internal partial interface INetworkProfileInternal

    {
        /// <summary>Profile of the HA Proxy load balancer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.INetworkProfileLoadBalancerProfile LoadBalancerProfile { get; set; }
        /// <summary>Number of HA Proxy load balancer VMs. The default value is 0.</summary>
        int? LoadBalancerProfileCount { get; set; }
        /// <summary>
        /// Network policy used for building Kubernetes network. Possible values include: 'calico'.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("calico")]
        string NetworkPolicy { get; set; }
        /// <summary>A CIDR notation IP Address range from which to assign pod IPs.</summary>
        string PodCidr { get; set; }

    }
}