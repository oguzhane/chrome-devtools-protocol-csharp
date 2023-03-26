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
    [JsonConverter(typeof(TypeHeavyAdIssueDetailsConverter))]
    public partial class TypeHeavyAdIssueDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resolution"u8);
            writer.WriteStringValue(Resolution);
            writer.WritePropertyName("reason"u8);
            writer.WriteStringValue(Reason);
            writer.WritePropertyName("frame"u8);
            writer.WriteObjectValue(Frame);
            writer.WriteEndObject();
        }

        internal static TypeHeavyAdIssueDetails DeserializeTypeHeavyAdIssueDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resolution = default;
            string reason = default;
            TypeAffectedFrame frame = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resolution"u8))
                {
                    resolution = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frame"u8))
                {
                    frame = TypeAffectedFrame.DeserializeTypeAffectedFrame(property.Value);
                    continue;
                }
            }
            return new TypeHeavyAdIssueDetails(resolution, reason, frame);
        }

        internal partial class TypeHeavyAdIssueDetailsConverter : JsonConverter<TypeHeavyAdIssueDetails>
        {
            public override void Write(Utf8JsonWriter writer, TypeHeavyAdIssueDetails model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeHeavyAdIssueDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeHeavyAdIssueDetails(document.RootElement);
            }
        }
    }
}
