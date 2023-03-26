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
    [JsonConverter(typeof(TypeCoverageRangeConverter))]
    public partial class TypeCoverageRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startOffset"u8);
            writer.WriteNumberValue(StartOffset);
            writer.WritePropertyName("endOffset"u8);
            writer.WriteNumberValue(EndOffset);
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            writer.WriteEndObject();
        }

        internal static TypeCoverageRange DeserializeTypeCoverageRange(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int startOffset = default;
            int endOffset = default;
            int count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startOffset"u8))
                {
                    startOffset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endOffset"u8))
                {
                    endOffset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
            }
            return new TypeCoverageRange(startOffset, endOffset, count);
        }

        internal partial class TypeCoverageRangeConverter : JsonConverter<TypeCoverageRange>
        {
            public override void Write(Utf8JsonWriter writer, TypeCoverageRange model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeCoverageRange Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeCoverageRange(document.RootElement);
            }
        }
    }
}
