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
    [JsonConverter(typeof(EventAttachedToTargetParamsConverter))]
    public partial class EventAttachedToTargetParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sessionId"u8);
            writer.WriteStringValue(SessionId);
            writer.WritePropertyName("targetInfo"u8);
            writer.WriteObjectValue(TargetInfo);
            writer.WritePropertyName("waitingForDebugger"u8);
            writer.WriteBooleanValue(WaitingForDebugger);
            writer.WriteEndObject();
        }

        internal static EventAttachedToTargetParams DeserializeEventAttachedToTargetParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sessionId = default;
            TypeTargetInfo targetInfo = default;
            bool waitingForDebugger = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetInfo"u8))
                {
                    targetInfo = TypeTargetInfo.DeserializeTypeTargetInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("waitingForDebugger"u8))
                {
                    waitingForDebugger = property.Value.GetBoolean();
                    continue;
                }
            }
            return new EventAttachedToTargetParams(sessionId, targetInfo, waitingForDebugger);
        }

        internal partial class EventAttachedToTargetParamsConverter : JsonConverter<EventAttachedToTargetParams>
        {
            public override void Write(Utf8JsonWriter writer, EventAttachedToTargetParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventAttachedToTargetParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventAttachedToTargetParams(document.RootElement);
            }
        }
    }
}
