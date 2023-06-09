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
    [JsonConverter(typeof(TypeLocationConverter))]
    public partial class TypeLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("scriptId"u8);
            writer.WriteStringValue(ScriptId);
            writer.WritePropertyName("lineNumber"u8);
            writer.WriteNumberValue(LineNumber);
            if (Optional.IsDefined(ColumnNumber))
            {
                writer.WritePropertyName("columnNumber"u8);
                writer.WriteNumberValue(ColumnNumber.Value);
            }
            writer.WriteEndObject();
        }

        internal static TypeLocation DeserializeTypeLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string scriptId = default;
            int lineNumber = default;
            Optional<int> columnNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scriptId"u8))
                {
                    scriptId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lineNumber"u8))
                {
                    lineNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    columnNumber = property.Value.GetInt32();
                    continue;
                }
            }
            return new TypeLocation(scriptId, lineNumber, Optional.ToNullable(columnNumber));
        }

        internal partial class TypeLocationConverter : JsonConverter<TypeLocation>
        {
            public override void Write(Utf8JsonWriter writer, TypeLocation model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeLocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeLocation(document.RootElement);
            }
        }
    }
}
