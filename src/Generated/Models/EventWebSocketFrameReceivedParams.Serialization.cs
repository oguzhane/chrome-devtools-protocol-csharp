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
    [JsonConverter(typeof(EventWebSocketFrameReceivedParamsConverter))]
    public partial class EventWebSocketFrameReceivedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("requestId"u8);
            writer.WriteStringValue(RequestId);
            writer.WritePropertyName("timestamp"u8);
            writer.WriteNumberValue(Timestamp);
            writer.WritePropertyName("response"u8);
            writer.WriteObjectValue(Response);
            writer.WriteEndObject();
        }

        internal static EventWebSocketFrameReceivedParams DeserializeEventWebSocketFrameReceivedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string requestId = default;
            float timestamp = default;
            TypeWebSocketFrame response = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    timestamp = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("response"u8))
                {
                    response = TypeWebSocketFrame.DeserializeTypeWebSocketFrame(property.Value);
                    continue;
                }
            }
            return new EventWebSocketFrameReceivedParams(requestId, timestamp, response);
        }

        internal partial class EventWebSocketFrameReceivedParamsConverter : JsonConverter<EventWebSocketFrameReceivedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventWebSocketFrameReceivedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventWebSocketFrameReceivedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventWebSocketFrameReceivedParams(document.RootElement);
            }
        }
    }
}
