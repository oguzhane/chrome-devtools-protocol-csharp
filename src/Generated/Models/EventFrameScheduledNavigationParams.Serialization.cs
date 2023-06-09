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
    [JsonConverter(typeof(EventFrameScheduledNavigationParamsConverter))]
    public partial class EventFrameScheduledNavigationParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("frameId"u8);
            writer.WriteStringValue(FrameId);
            writer.WritePropertyName("delay"u8);
            writer.WriteNumberValue(Delay);
            writer.WritePropertyName("reason"u8);
            writer.WriteStringValue(Reason);
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            writer.WriteEndObject();
        }

        internal static EventFrameScheduledNavigationParams DeserializeEventFrameScheduledNavigationParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string frameId = default;
            float delay = default;
            string reason = default;
            string url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frameId"u8))
                {
                    frameId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("delay"u8))
                {
                    delay = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new EventFrameScheduledNavigationParams(frameId, delay, reason, url);
        }

        internal partial class EventFrameScheduledNavigationParamsConverter : JsonConverter<EventFrameScheduledNavigationParams>
        {
            public override void Write(Utf8JsonWriter writer, EventFrameScheduledNavigationParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventFrameScheduledNavigationParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventFrameScheduledNavigationParams(document.RootElement);
            }
        }
    }
}
