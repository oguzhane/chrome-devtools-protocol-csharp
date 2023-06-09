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
    [JsonConverter(typeof(EventConsoleProfileStartedParamsConverter))]
    public partial class EventConsoleProfileStartedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("location"u8);
            writer.WriteObjectValue(Location);
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            writer.WriteEndObject();
        }

        internal static EventConsoleProfileStartedParams DeserializeEventConsoleProfileStartedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            TypeLocation location = default;
            Optional<string> title = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = TypeLocation.DeserializeTypeLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
            }
            return new EventConsoleProfileStartedParams(id, location, title.Value);
        }

        internal partial class EventConsoleProfileStartedParamsConverter : JsonConverter<EventConsoleProfileStartedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventConsoleProfileStartedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventConsoleProfileStartedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventConsoleProfileStartedParams(document.RootElement);
            }
        }
    }
}
