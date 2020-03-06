// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayAvailableSslOptionsPropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PredefinedPolicies != null)
            {
                writer.WritePropertyName("predefinedPolicies");
                writer.WriteStartArray();
                foreach (var item in PredefinedPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultPolicy != null)
            {
                writer.WritePropertyName("defaultPolicy");
                writer.WriteStringValue(DefaultPolicy.Value.ToString());
            }
            if (AvailableCipherSuites != null)
            {
                writer.WritePropertyName("availableCipherSuites");
                writer.WriteStartArray();
                foreach (var item in AvailableCipherSuites)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (AvailableProtocols != null)
            {
                writer.WritePropertyName("availableProtocols");
                writer.WriteStartArray();
                foreach (var item in AvailableProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayAvailableSslOptionsPropertiesFormat DeserializeApplicationGatewayAvailableSslOptionsPropertiesFormat(JsonElement element)
        {
            ApplicationGatewayAvailableSslOptionsPropertiesFormat result = new ApplicationGatewayAvailableSslOptionsPropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("predefinedPolicies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PredefinedPolicies = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.PredefinedPolicies.Add(SubResource.DeserializeSubResource(item));
                    }
                    continue;
                }
                if (property.NameEquals("defaultPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DefaultPolicy = new ApplicationGatewaySslPolicyName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availableCipherSuites"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AvailableCipherSuites = new List<ApplicationGatewaySslCipherSuite>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.AvailableCipherSuites.Add(new ApplicationGatewaySslCipherSuite(item.GetString()));
                    }
                    continue;
                }
                if (property.NameEquals("availableProtocols"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.AvailableProtocols = new List<ApplicationGatewaySslProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.AvailableProtocols.Add(new ApplicationGatewaySslProtocol(item.GetString()));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
