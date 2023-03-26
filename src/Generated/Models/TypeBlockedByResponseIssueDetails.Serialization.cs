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
    [JsonConverter(typeof(TypeBlockedByResponseIssueDetailsConverter))]
    public partial class TypeBlockedByResponseIssueDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("request"u8);
            writer.WriteObjectValue(Request);
            if (Optional.IsDefined(ParentFrame))
            {
                writer.WritePropertyName("parentFrame"u8);
                writer.WriteObjectValue(ParentFrame);
            }
            if (Optional.IsDefined(BlockedFrame))
            {
                writer.WritePropertyName("blockedFrame"u8);
                writer.WriteObjectValue(BlockedFrame);
            }
            writer.WritePropertyName("reason"u8);
            writer.WriteStringValue(Reason);
            writer.WriteEndObject();
        }

        internal static TypeBlockedByResponseIssueDetails DeserializeTypeBlockedByResponseIssueDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeAffectedRequest request = default;
            Optional<TypeAffectedFrame> parentFrame = default;
            Optional<TypeAffectedFrame> blockedFrame = default;
            string reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("request"u8))
                {
                    request = TypeAffectedRequest.DeserializeTypeAffectedRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("parentFrame"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    parentFrame = TypeAffectedFrame.DeserializeTypeAffectedFrame(property.Value);
                    continue;
                }
                if (property.NameEquals("blockedFrame"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    blockedFrame = TypeAffectedFrame.DeserializeTypeAffectedFrame(property.Value);
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new TypeBlockedByResponseIssueDetails(request, parentFrame.Value, blockedFrame.Value, reason);
        }

        internal partial class TypeBlockedByResponseIssueDetailsConverter : JsonConverter<TypeBlockedByResponseIssueDetails>
        {
            public override void Write(Utf8JsonWriter writer, TypeBlockedByResponseIssueDetails model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeBlockedByResponseIssueDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeBlockedByResponseIssueDetails(document.RootElement);
            }
        }
    }
}