// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Container network interface configuration child resource. </summary>
    public partial class ContainerNetworkInterfaceConfiguration : SubResource
    {
        /// <summary> The name of the resource. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> Sub Resource type. </summary>
        public string Type { get; internal set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> A list of ip configurations of the container network interface configuration. </summary>
        public ICollection<IPConfigurationProfile> IpConfigurations { get; set; }
        /// <summary> A list of container network interfaces created from this container network interface configuration. </summary>
        public ICollection<SubResource> ContainerNetworkInterfaces { get; set; }
        /// <summary> The provisioning state of the container network interface configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}
