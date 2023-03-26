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
    [JsonConverter(typeof(TypeLayoutShiftAttributionConverter))]
    public partial class TypeLayoutShiftAttribution : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("previousRect"u8);
            writer.WriteObjectValue(PreviousRect);
            writer.WritePropertyName("currentRect"u8);
            writer.WriteObjectValue(CurrentRect);
            if (Optional.IsDefined(NodeId))
            {
                writer.WritePropertyName("nodeId"u8);
                writer.WriteNumberValue(NodeId.Value);
            }
            writer.WriteEndObject();
        }

        internal static TypeLayoutShiftAttribution DeserializeTypeLayoutShiftAttribution(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeRect previousRect = default;
            TypeRect currentRect = default;
            Optional<int> nodeId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("previousRect"u8))
                {
                    previousRect = TypeRect.DeserializeTypeRect(property.Value);
                    continue;
                }
                if (property.NameEquals("currentRect"u8))
                {
                    currentRect = TypeRect.DeserializeTypeRect(property.Value);
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
            return new TypeLayoutShiftAttribution(previousRect, currentRect, Optional.ToNullable(nodeId));
        }

        internal partial class TypeLayoutShiftAttributionConverter : JsonConverter<TypeLayoutShiftAttribution>
        {
            public override void Write(Utf8JsonWriter writer, TypeLayoutShiftAttribution model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeLayoutShiftAttribution Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeLayoutShiftAttribution(document.RootElement);
            }
        }
    }
}