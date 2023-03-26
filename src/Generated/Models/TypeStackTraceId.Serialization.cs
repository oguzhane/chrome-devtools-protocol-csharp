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
    [JsonConverter(typeof(TypeStackTraceIdConverter))]
    public partial class TypeStackTraceId : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(DebuggerId))
            {
                writer.WritePropertyName("debuggerId"u8);
                writer.WriteStringValue(DebuggerId);
            }
            writer.WriteEndObject();
        }

        internal static TypeStackTraceId DeserializeTypeStackTraceId(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<string> debuggerId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("debuggerId"u8))
                {
                    debuggerId = property.Value.GetString();
                    continue;
                }
            }
            return new TypeStackTraceId(id, debuggerId.Value);
        }

        internal partial class TypeStackTraceIdConverter : JsonConverter<TypeStackTraceId>
        {
            public override void Write(Utf8JsonWriter writer, TypeStackTraceId model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeStackTraceId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeStackTraceId(document.RootElement);
            }
        }
    }
}
