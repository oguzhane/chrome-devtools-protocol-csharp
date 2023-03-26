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
    [JsonConverter(typeof(EventTrustTokenOperationDoneParamsConverter))]
    public partial class EventTrustTokenOperationDoneParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("requestId"u8);
            writer.WriteStringValue(RequestId);
            if (Optional.IsDefined(TopLevelOrigin))
            {
                writer.WritePropertyName("topLevelOrigin"u8);
                writer.WriteStringValue(TopLevelOrigin);
            }
            if (Optional.IsDefined(IssuerOrigin))
            {
                writer.WritePropertyName("issuerOrigin"u8);
                writer.WriteStringValue(IssuerOrigin);
            }
            if (Optional.IsDefined(IssuedTokenCount))
            {
                writer.WritePropertyName("issuedTokenCount"u8);
                writer.WriteNumberValue(IssuedTokenCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static EventTrustTokenOperationDoneParams DeserializeEventTrustTokenOperationDoneParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string status = default;
            string type = default;
            string requestId = default;
            Optional<string> topLevelOrigin = default;
            Optional<string> issuerOrigin = default;
            Optional<int> issuedTokenCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topLevelOrigin"u8))
                {
                    topLevelOrigin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuerOrigin"u8))
                {
                    issuerOrigin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuedTokenCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    issuedTokenCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new EventTrustTokenOperationDoneParams(status, type, requestId, topLevelOrigin.Value, issuerOrigin.Value, Optional.ToNullable(issuedTokenCount));
        }

        internal partial class EventTrustTokenOperationDoneParamsConverter : JsonConverter<EventTrustTokenOperationDoneParams>
        {
            public override void Write(Utf8JsonWriter writer, EventTrustTokenOperationDoneParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventTrustTokenOperationDoneParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventTrustTokenOperationDoneParams(document.RootElement);
            }
        }
    }
}