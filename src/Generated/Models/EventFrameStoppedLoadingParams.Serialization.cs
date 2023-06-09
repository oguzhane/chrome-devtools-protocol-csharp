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
    [JsonConverter(typeof(EventFrameStoppedLoadingParamsConverter))]
    public partial class EventFrameStoppedLoadingParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("frameId"u8);
            writer.WriteStringValue(FrameId);
            writer.WriteEndObject();
        }

        internal static EventFrameStoppedLoadingParams DeserializeEventFrameStoppedLoadingParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string frameId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frameId"u8))
                {
                    frameId = property.Value.GetString();
                    continue;
                }
            }
            return new EventFrameStoppedLoadingParams(frameId);
        }

        internal partial class EventFrameStoppedLoadingParamsConverter : JsonConverter<EventFrameStoppedLoadingParams>
        {
            public override void Write(Utf8JsonWriter writer, EventFrameStoppedLoadingParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventFrameStoppedLoadingParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventFrameStoppedLoadingParams(document.RootElement);
            }
        }
    }
}
