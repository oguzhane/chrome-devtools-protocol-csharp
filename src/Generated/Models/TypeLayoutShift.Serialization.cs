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
    [JsonConverter(typeof(TypeLayoutShiftConverter))]
    public partial class TypeLayoutShift : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            writer.WritePropertyName("hadRecentInput"u8);
            writer.WriteBooleanValue(HadRecentInput);
            writer.WritePropertyName("lastInputTime"u8);
            writer.WriteNumberValue(LastInputTime);
            writer.WritePropertyName("sources"u8);
            writer.WriteStartArray();
            foreach (var item in Sources)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static TypeLayoutShift DeserializeTypeLayoutShift(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float value = default;
            bool hadRecentInput = default;
            float lastInputTime = default;
            IList<TypeLayoutShiftAttribution> sources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("hadRecentInput"u8))
                {
                    hadRecentInput = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastInputTime"u8))
                {
                    lastInputTime = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sources"u8))
                {
                    List<TypeLayoutShiftAttribution> array = new List<TypeLayoutShiftAttribution>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TypeLayoutShiftAttribution.DeserializeTypeLayoutShiftAttribution(item));
                    }
                    sources = array;
                    continue;
                }
            }
            return new TypeLayoutShift(value, hadRecentInput, lastInputTime, sources);
        }

        internal partial class TypeLayoutShiftConverter : JsonConverter<TypeLayoutShift>
        {
            public override void Write(Utf8JsonWriter writer, TypeLayoutShift model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeLayoutShift Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeLayoutShift(document.RootElement);
            }
        }
    }
}
