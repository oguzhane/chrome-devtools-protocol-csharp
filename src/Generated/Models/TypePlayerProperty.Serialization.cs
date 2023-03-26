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
    [JsonConverter(typeof(TypePlayerPropertyConverter))]
    public partial class TypePlayerProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            writer.WriteEndObject();
        }

        internal static TypePlayerProperty DeserializeTypePlayerProperty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new TypePlayerProperty(name, value);
        }

        internal partial class TypePlayerPropertyConverter : JsonConverter<TypePlayerProperty>
        {
            public override void Write(Utf8JsonWriter writer, TypePlayerProperty model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypePlayerProperty Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypePlayerProperty(document.RootElement);
            }
        }
    }
}