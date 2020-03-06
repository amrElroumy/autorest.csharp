// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> IP configuration. </summary>
    public partial class IPConfiguration : SubResource
    {
        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> The private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The private IP address allocation method. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> The reference to the subnet resource. </summary>
        public Subnet Subnet { get; set; }
        /// <summary> The reference to the public IP resource. </summary>
        public PublicIPAddress PublicIPAddress { get; set; }
        /// <summary> The provisioning state of the IP configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}
