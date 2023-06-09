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
    [JsonConverter(typeof(EventPlayerPropertiesChangedParamsConverter))]
    public partial class EventPlayerPropertiesChangedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("playerId"u8);
            writer.WriteStringValue(PlayerId);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartArray();
            foreach (var item in Properties)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static EventPlayerPropertiesChangedParams DeserializeEventPlayerPropertiesChangedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string playerId = default;
            IList<TypePlayerProperty> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("playerId"u8))
                {
                    playerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    List<TypePlayerProperty> array = new List<TypePlayerProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TypePlayerProperty.DeserializeTypePlayerProperty(item));
                    }
                    properties = array;
                    continue;
                }
            }
            return new EventPlayerPropertiesChangedParams(playerId, properties);
        }

        internal partial class EventPlayerPropertiesChangedParamsConverter : JsonConverter<EventPlayerPropertiesChangedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventPlayerPropertiesChangedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventPlayerPropertiesChangedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventPlayerPropertiesChangedParams(document.RootElement);
            }
        }
    }
}
