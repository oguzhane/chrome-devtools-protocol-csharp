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
    [JsonConverter(typeof(TypeMetricConverter))]
    public partial class TypeMetric : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            writer.WriteEndObject();
        }

        internal static TypeMetric DeserializeTypeMetric(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            float value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetSingle();
                    continue;
                }
            }
            return new TypeMetric(name, value);
        }

        internal partial class TypeMetricConverter : JsonConverter<TypeMetric>
        {
            public override void Write(Utf8JsonWriter writer, TypeMetric model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeMetric Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeMetric(document.RootElement);
            }
        }
    }
}