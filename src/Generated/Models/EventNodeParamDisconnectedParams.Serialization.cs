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
    [JsonConverter(typeof(EventNodeParamDisconnectedParamsConverter))]
    public partial class EventNodeParamDisconnectedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("contextId"u8);
            writer.WriteStringValue(ContextId);
            writer.WritePropertyName("sourceId"u8);
            writer.WriteStringValue(SourceId);
            writer.WritePropertyName("destinationId"u8);
            writer.WriteStringValue(DestinationId);
            if (Optional.IsDefined(SourceOutputIndex))
            {
                writer.WritePropertyName("sourceOutputIndex"u8);
                writer.WriteNumberValue(SourceOutputIndex.Value);
            }
            writer.WriteEndObject();
        }

        internal static EventNodeParamDisconnectedParams DeserializeEventNodeParamDisconnectedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contextId = default;
            string sourceId = default;
            string destinationId = default;
            Optional<float> sourceOutputIndex = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contextId"u8))
                {
                    contextId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceId"u8))
                {
                    sourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationId"u8))
                {
                    destinationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceOutputIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceOutputIndex = property.Value.GetSingle();
                    continue;
                }
            }
            return new EventNodeParamDisconnectedParams(contextId, sourceId, destinationId, Optional.ToNullable(sourceOutputIndex));
        }

        internal partial class EventNodeParamDisconnectedParamsConverter : JsonConverter<EventNodeParamDisconnectedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventNodeParamDisconnectedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventNodeParamDisconnectedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventNodeParamDisconnectedParams(document.RootElement);
            }
        }
    }
}