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
    [JsonConverter(typeof(TypeCallFrameAutoGeneratedConverter))]
    public partial class TypeCallFrameAutoGenerated : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("functionName"u8);
            writer.WriteStringValue(FunctionName);
            writer.WritePropertyName("scriptId"u8);
            writer.WriteStringValue(ScriptId);
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            writer.WritePropertyName("lineNumber"u8);
            writer.WriteNumberValue(LineNumber);
            writer.WritePropertyName("columnNumber"u8);
            writer.WriteNumberValue(ColumnNumber);
            writer.WriteEndObject();
        }

        internal static TypeCallFrameAutoGenerated DeserializeTypeCallFrameAutoGenerated(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string functionName = default;
            string scriptId = default;
            string url = default;
            int lineNumber = default;
            int columnNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("functionName"u8))
                {
                    functionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptId"u8))
                {
                    scriptId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lineNumber"u8))
                {
                    lineNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnNumber"u8))
                {
                    columnNumber = property.Value.GetInt32();
                    continue;
                }
            }
            return new TypeCallFrameAutoGenerated(functionName, scriptId, url, lineNumber, columnNumber);
        }

        internal partial class TypeCallFrameAutoGeneratedConverter : JsonConverter<TypeCallFrameAutoGenerated>
        {
            public override void Write(Utf8JsonWriter writer, TypeCallFrameAutoGenerated model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeCallFrameAutoGenerated Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeCallFrameAutoGenerated(document.RootElement);
            }
        }
    }
}
