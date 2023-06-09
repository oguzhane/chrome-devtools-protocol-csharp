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
    [JsonConverter(typeof(EventAudioListenerCreatedParamsConverter))]
    public partial class EventAudioListenerCreatedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("listener"u8);
            writer.WriteObjectValue(Listener);
            writer.WriteEndObject();
        }

        internal static EventAudioListenerCreatedParams DeserializeEventAudioListenerCreatedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeAudioListener listener = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("listener"u8))
                {
                    listener = TypeAudioListener.DeserializeTypeAudioListener(property.Value);
                    continue;
                }
            }
            return new EventAudioListenerCreatedParams(listener);
        }

        internal partial class EventAudioListenerCreatedParamsConverter : JsonConverter<EventAudioListenerCreatedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventAudioListenerCreatedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventAudioListenerCreatedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventAudioListenerCreatedParams(document.RootElement);
            }
        }
    }
}
