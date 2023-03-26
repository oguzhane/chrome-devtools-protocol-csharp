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
    [JsonConverter(typeof(EventBreakpointResolvedParamsConverter))]
    public partial class EventBreakpointResolvedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("breakpointId"u8);
            writer.WriteStringValue(BreakpointId);
            writer.WritePropertyName("location"u8);
            writer.WriteObjectValue(Location);
            writer.WriteEndObject();
        }

        internal static EventBreakpointResolvedParams DeserializeEventBreakpointResolvedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string breakpointId = default;
            TypeLocation location = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("breakpointId"u8))
                {
                    breakpointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = TypeLocation.DeserializeTypeLocation(property.Value);
                    continue;
                }
            }
            return new EventBreakpointResolvedParams(breakpointId, location);
        }

        internal partial class EventBreakpointResolvedParamsConverter : JsonConverter<EventBreakpointResolvedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventBreakpointResolvedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventBreakpointResolvedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventBreakpointResolvedParams(document.RootElement);
            }
        }
    }
}
