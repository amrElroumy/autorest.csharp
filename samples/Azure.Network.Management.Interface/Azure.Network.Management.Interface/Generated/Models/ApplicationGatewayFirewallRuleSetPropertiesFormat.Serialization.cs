// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayFirewallRuleSetPropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("ruleSetType");
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion");
            writer.WriteStringValue(RuleSetVersion);
            writer.WritePropertyName("ruleGroups");
            writer.WriteStartArray();
            foreach (var item in RuleGroups)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayFirewallRuleSetPropertiesFormat DeserializeApplicationGatewayFirewallRuleSetPropertiesFormat(JsonElement element)
        {
            ApplicationGatewayFirewallRuleSetPropertiesFormat result = new ApplicationGatewayFirewallRuleSetPropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleSetType"))
                {
                    result.RuleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"))
                {
                    result.RuleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleGroups"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.RuleGroups.Add(ApplicationGatewayFirewallRuleGroup.DeserializeApplicationGatewayFirewallRuleGroup(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
