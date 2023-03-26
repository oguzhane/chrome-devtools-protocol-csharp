// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    [JsonConverter(typeof(TypeNavigatorUserAgentIssueDetailsConverter))]
    public partial class TypeNavigatorUserAgentIssueDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteObjectValue(Location);
            }
            writer.WriteEndObject();
        }

        internal static TypeNavigatorUserAgentIssueDetails DeserializeTypeNavigatorUserAgentIssueDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string url = default;
            Optional<TypeSourceCodeLocation> location = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = TypeSourceCodeLocation.DeserializeTypeSourceCodeLocation(property.Value);
                    continue;
                }
            }
            return new TypeNavigatorUserAgentIssueDetails(url, location.Value);
        }

        internal partial class TypeNavigatorUserAgentIssueDetailsConverter : JsonConverter<TypeNavigatorUserAgentIssueDetails>
        {
            public override void Write(Utf8JsonWriter writer, TypeNavigatorUserAgentIssueDetails model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeNavigatorUserAgentIssueDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeNavigatorUserAgentIssueDetails(document.RootElement);
            }
        }
    }
}
