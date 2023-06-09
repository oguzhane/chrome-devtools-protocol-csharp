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
    [JsonConverter(typeof(EventRuleSetRemovedParamsConverter))]
    public partial class EventRuleSetRemovedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WriteEndObject();
        }

        internal static EventRuleSetRemovedParams DeserializeEventRuleSetRemovedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new EventRuleSetRemovedParams(id);
        }

        internal partial class EventRuleSetRemovedParamsConverter : JsonConverter<EventRuleSetRemovedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventRuleSetRemovedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventRuleSetRemovedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventRuleSetRemovedParams(document.RootElement);
            }
        }
    }
}
