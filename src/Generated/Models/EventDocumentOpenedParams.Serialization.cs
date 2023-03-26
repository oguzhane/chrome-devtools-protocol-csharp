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
    [JsonConverter(typeof(EventDocumentOpenedParamsConverter))]
    public partial class EventDocumentOpenedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("frame"u8);
            writer.WriteObjectValue(Frame);
            writer.WriteEndObject();
        }

        internal static EventDocumentOpenedParams DeserializeEventDocumentOpenedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeFrame frame = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frame"u8))
                {
                    frame = TypeFrame.DeserializeTypeFrame(property.Value);
                    continue;
                }
            }
            return new EventDocumentOpenedParams(frame);
        }

        internal partial class EventDocumentOpenedParamsConverter : JsonConverter<EventDocumentOpenedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventDocumentOpenedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventDocumentOpenedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventDocumentOpenedParams(document.RootElement);
            }
        }
    }
}
