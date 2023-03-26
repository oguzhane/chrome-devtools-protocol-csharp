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
    [JsonConverter(typeof(TypeContextRealtimeDataConverter))]
    public partial class TypeContextRealtimeData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("currentTime"u8);
            writer.WriteNumberValue(CurrentTime);
            writer.WritePropertyName("renderCapacity"u8);
            writer.WriteNumberValue(RenderCapacity);
            writer.WritePropertyName("callbackIntervalMean"u8);
            writer.WriteNumberValue(CallbackIntervalMean);
            writer.WritePropertyName("callbackIntervalVariance"u8);
            writer.WriteNumberValue(CallbackIntervalVariance);
            writer.WriteEndObject();
        }

        internal static TypeContextRealtimeData DeserializeTypeContextRealtimeData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float currentTime = default;
            float renderCapacity = default;
            float callbackIntervalMean = default;
            float callbackIntervalVariance = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentTime"u8))
                {
                    currentTime = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("renderCapacity"u8))
                {
                    renderCapacity = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("callbackIntervalMean"u8))
                {
                    callbackIntervalMean = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("callbackIntervalVariance"u8))
                {
                    callbackIntervalVariance = property.Value.GetSingle();
                    continue;
                }
            }
            return new TypeContextRealtimeData(currentTime, renderCapacity, callbackIntervalMean, callbackIntervalVariance);
        }

        internal partial class TypeContextRealtimeDataConverter : JsonConverter<TypeContextRealtimeData>
        {
            public override void Write(Utf8JsonWriter writer, TypeContextRealtimeData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeContextRealtimeData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeContextRealtimeData(document.RootElement);
            }
        }
    }
}
