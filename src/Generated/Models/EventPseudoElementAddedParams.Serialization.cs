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
    [JsonConverter(typeof(EventPseudoElementAddedParamsConverter))]
    public partial class EventPseudoElementAddedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parentId"u8);
            writer.WriteNumberValue(ParentId);
            writer.WritePropertyName("pseudoElement"u8);
            writer.WriteObjectValue(PseudoElement);
            writer.WriteEndObject();
        }

        internal static EventPseudoElementAddedParams DeserializeEventPseudoElementAddedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int parentId = default;
            TypeNode pseudoElement = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentId"u8))
                {
                    parentId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pseudoElement"u8))
                {
                    pseudoElement = TypeNode.DeserializeTypeNode(property.Value);
                    continue;
                }
            }
            return new EventPseudoElementAddedParams(parentId, pseudoElement);
        }

        internal partial class EventPseudoElementAddedParamsConverter : JsonConverter<EventPseudoElementAddedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventPseudoElementAddedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventPseudoElementAddedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventPseudoElementAddedParams(document.RootElement);
            }
        }
    }
}
