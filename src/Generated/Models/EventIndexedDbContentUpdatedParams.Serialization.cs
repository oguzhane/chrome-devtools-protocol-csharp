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
    [JsonConverter(typeof(EventIndexedDbContentUpdatedParamsConverter))]
    public partial class EventIndexedDbContentUpdatedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("origin"u8);
            writer.WriteStringValue(Origin);
            writer.WritePropertyName("storageKey"u8);
            writer.WriteStringValue(StorageKey);
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("objectStoreName"u8);
            writer.WriteStringValue(ObjectStoreName);
            writer.WriteEndObject();
        }

        internal static EventIndexedDbContentUpdatedParams DeserializeEventIndexedDbContentUpdatedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string origin = default;
            string storageKey = default;
            string databaseName = default;
            string objectStoreName = default;
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
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectStoreName"u8))
                {
                    objectStoreName = property.Value.GetString();
                    continue;
                }
            }
            return new EventIndexedDbContentUpdatedParams(origin, storageKey, databaseName, objectStoreName);
        }

        internal partial class EventIndexedDbContentUpdatedParamsConverter : JsonConverter<EventIndexedDbContentUpdatedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventIndexedDbContentUpdatedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventIndexedDbContentUpdatedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventIndexedDbContentUpdatedParams(document.RootElement);
            }
        }
    }
}
