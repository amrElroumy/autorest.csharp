// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayProbeHealthResponseMatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Body != null)
            {
                writer.WritePropertyName("body");
                writer.WriteStringValue(Body);
            }
            if (StatusCodes != null)
            {
                writer.WritePropertyName("statusCodes");
                writer.WriteStartArray();
                foreach (var item in StatusCodes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayProbeHealthResponseMatch DeserializeApplicationGatewayProbeHealthResponseMatch(JsonElement element)
        {
            ApplicationGatewayProbeHealthResponseMatch result = new ApplicationGatewayProbeHealthResponseMatch();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("body"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Body = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusCodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.StatusCodes = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.StatusCodes.Add(item.GetString());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
