// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Backend Address Pool of an application gateway. </summary>
    public partial class ApplicationGatewayBackendAddressPool : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayBackendAddressPool. </summary>
        public ApplicationGatewayBackendAddressPool()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayBackendAddressPool. </summary>
        /// <param name="name"> Name of the backend address pool that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="backendIPConfigurations"> Collection of references to IPs defined in network interfaces. </param>
        /// <param name="backendAddresses"> Backend addresses. </param>
        /// <param name="provisioningState"> The provisioning state of the backend address pool resource. </param>
        /// <param name="id"> Resource ID. </param>
        internal ApplicationGatewayBackendAddressPool(string name, string etag, string type, IList<NetworkInterfaceIPConfiguration> backendIPConfigurations, IList<ApplicationGatewayBackendAddress> backendAddresses, ProvisioningState? provisioningState, string id) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            BackendIPConfigurations = backendIPConfigurations;
            BackendAddresses = backendAddresses;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the backend address pool that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; internal set; }
        /// <summary> Collection of references to IPs defined in network interfaces. </summary>
        public IList<NetworkInterfaceIPConfiguration> BackendIPConfigurations { get; internal set; }
        /// <summary> Backend addresses. </summary>
        public IList<ApplicationGatewayBackendAddress> BackendAddresses { get; set; }
        /// <summary> The provisioning state of the backend address pool resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
    }
}
