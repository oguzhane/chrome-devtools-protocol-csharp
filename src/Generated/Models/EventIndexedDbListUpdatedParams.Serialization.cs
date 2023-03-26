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
    [JsonConverter(typeof(EventIndexedDbListUpdatedParamsConverter))]
    public partial class EventIndexedDbListUpdatedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("origin"u8);
            writer.WriteStringValue(Origin);
            writer.WritePropertyName("storageKey"u8);
            writer.WriteStringValue(StorageKey);
            writer.WriteEndObject();
        }

        internal static EventIndexedDbListUpdatedParams DeserializeEventIndexedDbListUpdatedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string origin = default;
            string storageKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origin"u8))
                {
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageKey"u8))
                {
                    storageKey = property.Value.GetString();
                    continue;
                }
            }
            return new EventIndexedDbListUpdatedParams(origin, storageKey);
        }

        internal partial class EventIndexedDbListUpdatedParamsConverter : JsonConverter<EventIndexedDbListUpdatedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventIndexedDbListUpdatedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventIndexedDbListUpdatedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventIndexedDbListUpdatedParams(document.RootElement);
            }
        }
    }
}
