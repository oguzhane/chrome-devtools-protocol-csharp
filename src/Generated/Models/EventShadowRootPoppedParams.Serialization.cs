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
    [JsonConverter(typeof(EventShadowRootPoppedParamsConverter))]
    public partial class EventShadowRootPoppedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hostId"u8);
            writer.WriteNumberValue(HostId);
            writer.WritePropertyName("rootId"u8);
            writer.WriteNumberValue(RootId);
            writer.WriteEndObject();
        }

        internal static EventShadowRootPoppedParams DeserializeEventShadowRootPoppedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int hostId = default;
            int rootId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostId"u8))
                {
                    hostId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rootId"u8))
                {
                    rootId = property.Value.GetInt32();
                    continue;
                }
            }
            return new EventShadowRootPoppedParams(hostId, rootId);
        }

        internal partial class EventShadowRootPoppedParamsConverter : JsonConverter<EventShadowRootPoppedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventShadowRootPoppedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventShadowRootPoppedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventShadowRootPoppedParams(document.RootElement);
            }
        }
    }
}
