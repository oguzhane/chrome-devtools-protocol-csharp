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
    [JsonConverter(typeof(EventRecordingStateChangedParamsConverter))]
    public partial class EventRecordingStateChangedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("isRecording"u8);
            writer.WriteBooleanValue(IsRecording);
            writer.WritePropertyName("service"u8);
            writer.WriteStringValue(Service);
            writer.WriteEndObject();
        }

        internal static EventRecordingStateChangedParams DeserializeEventRecordingStateChangedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isRecording = default;
            string service = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isRecording"u8))
                {
                    isRecording = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("service"u8))
                {
                    service = property.Value.GetString();
                    continue;
                }
            }
            return new EventRecordingStateChangedParams(isRecording, service);
        }

        internal partial class EventRecordingStateChangedParamsConverter : JsonConverter<EventRecordingStateChangedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventRecordingStateChangedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventRecordingStateChangedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventRecordingStateChangedParams(document.RootElement);
            }
        }
    }
}
