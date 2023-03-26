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
    [JsonConverter(typeof(EventShadowRootPushedParamsConverter))]
    public partial class EventShadowRootPushedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hostId"u8);
            writer.WriteNumberValue(HostId);
            writer.WritePropertyName("root"u8);
            writer.WriteObjectValue(Root);
            writer.WriteEndObject();
        }

        internal static EventShadowRootPushedParams DeserializeEventShadowRootPushedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int hostId = default;
            TypeNode root = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostId"u8))
                {
                    hostId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("root"u8))
                {
                    root = TypeNode.DeserializeTypeNode(property.Value);
                    continue;
                }
            }
            return new EventShadowRootPushedParams(hostId, root);
        }

        internal partial class EventShadowRootPushedParamsConverter : JsonConverter<EventShadowRootPushedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventShadowRootPushedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventShadowRootPushedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventShadowRootPushedParams(document.RootElement);
            }
        }
    }
}
