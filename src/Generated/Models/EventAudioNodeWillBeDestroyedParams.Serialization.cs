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
    [JsonConverter(typeof(EventAudioNodeWillBeDestroyedParamsConverter))]
    public partial class EventAudioNodeWillBeDestroyedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("contextId"u8);
            writer.WriteStringValue(ContextId);
            writer.WritePropertyName("nodeId"u8);
            writer.WriteStringValue(NodeId);
            writer.WriteEndObject();
        }

        internal static EventAudioNodeWillBeDestroyedParams DeserializeEventAudioNodeWillBeDestroyedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contextId = default;
            string nodeId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contextId"u8))
                {
                    contextId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeId"u8))
                {
                    nodeId = property.Value.GetString();
                    continue;
                }
            }
            return new EventAudioNodeWillBeDestroyedParams(contextId, nodeId);
        }

        internal partial class EventAudioNodeWillBeDestroyedParamsConverter : JsonConverter<EventAudioNodeWillBeDestroyedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventAudioNodeWillBeDestroyedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventAudioNodeWillBeDestroyedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventAudioNodeWillBeDestroyedParams(document.RootElement);
            }
        }
    }
}
