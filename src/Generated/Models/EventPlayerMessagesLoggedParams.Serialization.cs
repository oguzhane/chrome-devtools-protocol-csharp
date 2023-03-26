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
    [JsonConverter(typeof(EventPlayerMessagesLoggedParamsConverter))]
    public partial class EventPlayerMessagesLoggedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("playerId"u8);
            writer.WriteStringValue(PlayerId);
            writer.WritePropertyName("messages"u8);
            writer.WriteStartArray();
            foreach (var item in Messages)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static EventPlayerMessagesLoggedParams DeserializeEventPlayerMessagesLoggedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string playerId = default;
            IList<TypePlayerMessage> messages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("playerId"u8))
                {
                    playerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messages"u8))
                {
                    List<TypePlayerMessage> array = new List<TypePlayerMessage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TypePlayerMessage.DeserializeTypePlayerMessage(item));
                    }
                    messages = array;
                    continue;
                }
            }
            return new EventPlayerMessagesLoggedParams(playerId, messages);
        }

        internal partial class EventPlayerMessagesLoggedParamsConverter : JsonConverter<EventPlayerMessagesLoggedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventPlayerMessagesLoggedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventPlayerMessagesLoggedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventPlayerMessagesLoggedParams(document.RootElement);
            }
        }
    }
}
