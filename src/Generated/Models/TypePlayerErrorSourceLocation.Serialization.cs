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
    [JsonConverter(typeof(TypePlayerErrorSourceLocationConverter))]
    public partial class TypePlayerErrorSourceLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("file"u8);
            writer.WriteStringValue(File);
            writer.WritePropertyName("line"u8);
            writer.WriteNumberValue(Line);
            writer.WriteEndObject();
        }

        internal static TypePlayerErrorSourceLocation DeserializeTypePlayerErrorSourceLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string file = default;
            int line = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file"u8))
                {
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("line"u8))
                {
                    line = property.Value.GetInt32();
                    continue;
                }
            }
            return new TypePlayerErrorSourceLocation(file, line);
        }

        internal partial class TypePlayerErrorSourceLocationConverter : JsonConverter<TypePlayerErrorSourceLocation>
        {
            public override void Write(Utf8JsonWriter writer, TypePlayerErrorSourceLocation model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypePlayerErrorSourceLocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypePlayerErrorSourceLocation(document.RootElement);
            }
        }
    }
}
