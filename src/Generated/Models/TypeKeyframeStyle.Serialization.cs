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
    [JsonConverter(typeof(TypeKeyframeStyleConverter))]
    public partial class TypeKeyframeStyle : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("offset"u8);
            writer.WriteStringValue(Offset);
            writer.WritePropertyName("easing"u8);
            writer.WriteStringValue(Easing);
            writer.WriteEndObject();
        }

        internal static TypeKeyframeStyle DeserializeTypeKeyframeStyle(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offset = default;
            string easing = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("easing"u8))
                {
                    easing = property.Value.GetString();
                    continue;
                }
            }
            return new TypeKeyframeStyle(offset, easing);
        }

        internal partial class TypeKeyframeStyleConverter : JsonConverter<TypeKeyframeStyle>
        {
            public override void Write(Utf8JsonWriter writer, TypeKeyframeStyle model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeKeyframeStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeKeyframeStyle(document.RootElement);
            }
        }
    }
}