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
    [JsonConverter(typeof(EventLoadCompleteParamsConverter))]
    public partial class EventLoadCompleteParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("root"u8);
            writer.WriteObjectValue(Root);
            writer.WriteEndObject();
        }

        internal static EventLoadCompleteParams DeserializeEventLoadCompleteParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeAxNode root = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("root"u8))
                {
                    root = TypeAxNode.DeserializeTypeAxNode(property.Value);
                    continue;
                }
            }
            return new EventLoadCompleteParams(root);
        }

        internal partial class EventLoadCompleteParamsConverter : JsonConverter<EventLoadCompleteParams>
        {
            public override void Write(Utf8JsonWriter writer, EventLoadCompleteParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventLoadCompleteParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventLoadCompleteParams(document.RootElement);
            }
        }
    }
}