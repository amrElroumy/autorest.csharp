// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> DhcpOptions contains an array of DNS servers available to VMs deployed in the virtual network. Standard DHCP option for a subnet overrides VNET DHCP options. </summary>
    public partial class DhcpOptions
    {
        /// <summary> The list of DNS servers IP addresses. </summary>
        public ICollection<string> DnsServers { get; set; }
    }
}
