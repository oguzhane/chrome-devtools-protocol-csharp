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
    [JsonConverter(typeof(EventMessageAddedParamsConverter))]
    public partial class EventMessageAddedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("message"u8);
            writer.WriteObjectValue(Message);
            writer.WriteEndObject();
        }

        internal static EventMessageAddedParams DeserializeEventMessageAddedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeConsoleMessage message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = TypeConsoleMessage.DeserializeTypeConsoleMessage(property.Value);
                    continue;
                }
            }
            return new EventMessageAddedParams(message);
        }

        internal partial class EventMessageAddedParamsConverter : JsonConverter<EventMessageAddedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventMessageAddedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventMessageAddedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventMessageAddedParams(document.RootElement);
            }
        }
    }
}