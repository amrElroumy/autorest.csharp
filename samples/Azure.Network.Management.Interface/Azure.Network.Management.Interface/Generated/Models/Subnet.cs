// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Subnet in a virtual network resource. </summary>
    public partial class Subnet : SubResource
    {
        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> The address prefix for the subnet. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> List of address prefixes for the subnet. </summary>
        public ICollection<string> AddressPrefixes { get; set; }
        /// <summary> The reference to the NetworkSecurityGroup resource. </summary>
        public NetworkSecurityGroup NetworkSecurityGroup { get; set; }
        /// <summary> The reference to the RouteTable resource. </summary>
        public RouteTable RouteTable { get; set; }
        /// <summary> Nat gateway associated with this subnet. </summary>
        public SubResource NatGateway { get; set; }
        /// <summary> An array of service endpoints. </summary>
        public ICollection<ServiceEndpointPropertiesFormat> ServiceEndpoints { get; set; }
        /// <summary> An array of service endpoint policies. </summary>
        public ICollection<ServiceEndpointPolicy> ServiceEndpointPolicies { get; set; }
        /// <summary> An array of references to private endpoints. </summary>
        public ICollection<PrivateEndpoint> PrivateEndpoints { get; internal set; }
        /// <summary> An array of references to the network interface IP configurations using subnet. </summary>
        public ICollection<IPConfiguration> IpConfigurations { get; internal set; }
        /// <summary> Array of IP configuration profiles which reference this subnet. </summary>
        public ICollection<IPConfigurationProfile> IpConfigurationProfiles { get; internal set; }
        /// <summary> An array of references to the external resources using subnet. </summary>
        public ICollection<ResourceNavigationLink> ResourceNavigationLinks { get; internal set; }
        /// <summary> An array of references to services injecting into this subnet. </summary>
        public ICollection<ServiceAssociationLink> ServiceAssociationLinks { get; internal set; }
        /// <summary> An array of references to the delegations on the subnet. </summary>
        public ICollection<Delegation> Delegations { get; set; }
        /// <summary> A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties. </summary>
        public string Purpose { get; internal set; }
        /// <summary> The provisioning state of the subnet resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
        /// <summary> Enable or Disable apply network policies on private end point in the subnet. </summary>
        public string PrivateEndpointNetworkPolicies { get; set; }
        /// <summary> Enable or Disable apply network policies on private link service in the subnet. </summary>
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }
}
