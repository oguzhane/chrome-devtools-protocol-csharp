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
    [JsonConverter(typeof(EventResourceChangedPriorityParamsConverter))]
    public partial class EventResourceChangedPriorityParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("requestId"u8);
            writer.WriteStringValue(RequestId);
            writer.WritePropertyName("newPriority"u8);
            writer.WriteStringValue(NewPriority);
            writer.WritePropertyName("timestamp"u8);
            writer.WriteNumberValue(Timestamp);
            writer.WriteEndObject();
        }

        internal static EventResourceChangedPriorityParams DeserializeEventResourceChangedPriorityParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string requestId = default;
            string newPriority = default;
            float timestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("newPriority"u8))
                {
                    newPriority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    timestamp = property.Value.GetSingle();
                    continue;
                }
            }
            return new EventResourceChangedPriorityParams(requestId, newPriority, timestamp);
        }

        internal partial class EventResourceChangedPriorityParamsConverter : JsonConverter<EventResourceChangedPriorityParams>
        {
            public override void Write(Utf8JsonWriter writer, EventResourceChangedPriorityParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventResourceChangedPriorityParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventResourceChangedPriorityParams(document.RootElement);
            }
        }
    }
}
