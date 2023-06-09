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
    [JsonConverter(typeof(EventAddDatabaseParamsConverter))]
    public partial class EventAddDatabaseParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("database"u8);
            writer.WriteObjectValue(Database);
            writer.WriteEndObject();
        }

        internal static EventAddDatabaseParams DeserializeEventAddDatabaseParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeDatabase database = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("database"u8))
                {
                    database = TypeDatabase.DeserializeTypeDatabase(property.Value);
                    continue;
                }
            }
            return new EventAddDatabaseParams(database);
        }

        internal partial class EventAddDatabaseParamsConverter : JsonConverter<EventAddDatabaseParams>
        {
            public override void Write(Utf8JsonWriter writer, EventAddDatabaseParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventAddDatabaseParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventAddDatabaseParams(document.RootElement);
            }
        }
    }
}
