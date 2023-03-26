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
    [JsonConverter(typeof(EventChildNodeCountUpdatedParamsConverter))]
    public partial class EventChildNodeCountUpdatedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("nodeId"u8);
            writer.WriteNumberValue(NodeId);
            writer.WritePropertyName("childNodeCount"u8);
            writer.WriteNumberValue(ChildNodeCount);
            writer.WriteEndObject();
        }

        internal static EventChildNodeCountUpdatedParams DeserializeEventChildNodeCountUpdatedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int nodeId = default;
            int childNodeCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeId"u8))
                {
                    nodeId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("childNodeCount"u8))
                {
                    childNodeCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new EventChildNodeCountUpdatedParams(nodeId, childNodeCount);
        }

        internal partial class EventChildNodeCountUpdatedParamsConverter : JsonConverter<EventChildNodeCountUpdatedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventChildNodeCountUpdatedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventChildNodeCountUpdatedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventChildNodeCountUpdatedParams(document.RootElement);
            }
        }
    }
}