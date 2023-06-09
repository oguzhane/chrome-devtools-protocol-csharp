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
    [JsonConverter(typeof(EventDomStorageItemAddedParamsConverter))]
    public partial class EventDomStorageItemAddedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageId"u8);
            writer.WriteObjectValue(StorageId);
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(Key);
            writer.WritePropertyName("newValue"u8);
            writer.WriteStringValue(NewValue);
            writer.WriteEndObject();
        }

        internal static EventDomStorageItemAddedParams DeserializeEventDomStorageItemAddedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeStorageId storageId = default;
            string key = default;
            string newValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageId"u8))
                {
                    storageId = TypeStorageId.DeserializeTypeStorageId(property.Value);
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("newValue"u8))
                {
                    newValue = property.Value.GetString();
                    continue;
                }
            }
            return new EventDomStorageItemAddedParams(storageId, key, newValue);
        }

        internal partial class EventDomStorageItemAddedParamsConverter : JsonConverter<EventDomStorageItemAddedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventDomStorageItemAddedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventDomStorageItemAddedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventDomStorageItemAddedParams(document.RootElement);
            }
        }
    }
}
