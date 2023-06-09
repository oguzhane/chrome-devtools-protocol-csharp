// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    [JsonConverter(typeof(EventPlayerEventsAddedParamsConverter))]
    public partial class EventPlayerEventsAddedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("playerId"u8);
            writer.WriteStringValue(PlayerId);
            writer.WritePropertyName("events"u8);
            writer.WriteStartArray();
            foreach (var item in Events)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static EventPlayerEventsAddedParams DeserializeEventPlayerEventsAddedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string playerId = default;
            IList<TypePlayerEvent> events = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("playerId"u8))
                {
                    playerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    List<TypePlayerEvent> array = new List<TypePlayerEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TypePlayerEvent.DeserializeTypePlayerEvent(item));
                    }
                    events = array;
                    continue;
                }
            }
            return new EventPlayerEventsAddedParams(playerId, events);
        }

        internal partial class EventPlayerEventsAddedParamsConverter : JsonConverter<EventPlayerEventsAddedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventPlayerEventsAddedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventPlayerEventsAddedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventPlayerEventsAddedParams(document.RootElement);
            }
        }
    }
}
