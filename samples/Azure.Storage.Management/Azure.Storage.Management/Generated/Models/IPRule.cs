// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Management.Models
{
    /// <summary> IP rule with specific IP or IP range in CIDR format. </summary>
    public partial class IPRule
    {
        /// <summary> Initializes a new instance of IPRule. </summary>
        public IPRule()
        {
        }

        /// <summary> Initializes a new instance of IPRule. </summary>
        /// <param name="iPAddressOrRange"> Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed. </param>
        /// <param name="action"> The action of IP ACL rule. </param>
        internal IPRule(string iPAddressOrRange, string action)
        {
            IPAddressOrRange = iPAddressOrRange;
            Action = action;
        }

        /// <summary> Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed. </summary>
        public string IPAddressOrRange { get; set; }
        /// <summary> The action of IP ACL rule. </summary>
        public string Action { get; set; } = "Allow";
    }
}
