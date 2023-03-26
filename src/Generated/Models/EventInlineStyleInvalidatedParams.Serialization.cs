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
    [JsonConverter(typeof(EventInlineStyleInvalidatedParamsConverter))]
    public partial class EventInlineStyleInvalidatedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("nodeIds"u8);
            writer.WriteStartArray();
            foreach (var item in NodeIds)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static EventInlineStyleInvalidatedParams DeserializeEventInlineStyleInvalidatedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<int> nodeIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeIds"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    nodeIds = array;
                    continue;
                }
            }
            return new EventInlineStyleInvalidatedParams(nodeIds);
        }

        internal partial class EventInlineStyleInvalidatedParamsConverter : JsonConverter<EventInlineStyleInvalidatedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventInlineStyleInvalidatedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventInlineStyleInvalidatedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventInlineStyleInvalidatedParams(document.RootElement);
            }
        }
    }
}