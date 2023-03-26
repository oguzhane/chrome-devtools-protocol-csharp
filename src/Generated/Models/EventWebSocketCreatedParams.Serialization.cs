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
    [JsonConverter(typeof(EventWebSocketCreatedParamsConverter))]
    public partial class EventWebSocketCreatedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("requestId"u8);
            writer.WriteStringValue(RequestId);
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            if (Optional.IsDefined(Initiator))
            {
                writer.WritePropertyName("initiator"u8);
                writer.WriteObjectValue(Initiator);
            }
            writer.WriteEndObject();
        }

        internal static EventWebSocketCreatedParams DeserializeEventWebSocketCreatedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string requestId = default;
            string url = default;
            Optional<TypeInitiator> initiator = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initiator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initiator = TypeInitiator.DeserializeTypeInitiator(property.Value);
                    continue;
                }
            }
            return new EventWebSocketCreatedParams(requestId, url, initiator.Value);
        }

        internal partial class EventWebSocketCreatedParamsConverter : JsonConverter<EventWebSocketCreatedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventWebSocketCreatedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventWebSocketCreatedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventWebSocketCreatedParams(document.RootElement);
            }
        }
    }
}
