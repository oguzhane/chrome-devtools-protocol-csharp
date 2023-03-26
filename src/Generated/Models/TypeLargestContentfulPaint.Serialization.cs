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
    [JsonConverter(typeof(TypeLargestContentfulPaintConverter))]
    public partial class TypeLargestContentfulPaint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("renderTime"u8);
            writer.WriteNumberValue(RenderTime);
            writer.WritePropertyName("loadTime"u8);
            writer.WriteNumberValue(LoadTime);
            writer.WritePropertyName("size"u8);
            writer.WriteNumberValue(Size);
            if (Optional.IsDefined(ElementId))
            {
                writer.WritePropertyName("elementId"u8);
                writer.WriteStringValue(ElementId);
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url);
            }
            if (Optional.IsDefined(NodeId))
            {
                writer.WritePropertyName("nodeId"u8);
                writer.WriteNumberValue(NodeId.Value);
            }
            writer.WriteEndObject();
        }

        internal static TypeLargestContentfulPaint DeserializeTypeLargestContentfulPaint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float renderTime = default;
            float loadTime = default;
            float size = default;
            Optional<string> elementId = default;
            Optional<string> url = default;
            Optional<int> nodeId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("renderTime"u8))
                {
                    renderTime = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("loadTime"u8))
                {
                    loadTime = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("elementId"u8))
                {
                    elementId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodeId = property.Value.GetInt32();
                    continue;
                }
            }
            return new TypeLargestContentfulPaint(renderTime, loadTime, size, elementId.Value, url.Value, Optional.ToNullable(nodeId));
        }

        internal partial class TypeLargestContentfulPaintConverter : JsonConverter<TypeLargestContentfulPaint>
        {
            public override void Write(Utf8JsonWriter writer, TypeLargestContentfulPaint model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeLargestContentfulPaint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeLargestContentfulPaint(document.RootElement);
            }
        }
    }
}