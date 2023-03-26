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
    [JsonConverter(typeof(EventDomContentEventFiredParamsConverter))]
    public partial class EventDomContentEventFiredParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("timestamp"u8);
            writer.WriteNumberValue(Timestamp);
            writer.WriteEndObject();
        }

        internal static EventDomContentEventFiredParams DeserializeEventDomContentEventFiredParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float timestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    timestamp = property.Value.GetSingle();
                    continue;
                }
            }
            return new EventDomContentEventFiredParams(timestamp);
        }

        internal partial class EventDomContentEventFiredParamsConverter : JsonConverter<EventDomContentEventFiredParams>
        {
            public override void Write(Utf8JsonWriter writer, EventDomContentEventFiredParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventDomContentEventFiredParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventDomContentEventFiredParams(document.RootElement);
            }
        }
    }
}
