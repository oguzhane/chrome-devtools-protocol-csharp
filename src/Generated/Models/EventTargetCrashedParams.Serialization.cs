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
    [JsonConverter(typeof(EventTargetCrashedParamsConverter))]
    public partial class EventTargetCrashedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetId"u8);
            writer.WriteStringValue(TargetId);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
            writer.WritePropertyName("errorCode"u8);
            writer.WriteNumberValue(ErrorCode);
            writer.WriteEndObject();
        }

        internal static EventTargetCrashedParams DeserializeEventTargetCrashedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetId = default;
            string status = default;
            int errorCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetId"u8))
                {
                    targetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetInt32();
                    continue;
                }
            }
            return new EventTargetCrashedParams(targetId, status, errorCode);
        }

        internal partial class EventTargetCrashedParamsConverter : JsonConverter<EventTargetCrashedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventTargetCrashedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventTargetCrashedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventTargetCrashedParams(document.RootElement);
            }
        }
    }
}