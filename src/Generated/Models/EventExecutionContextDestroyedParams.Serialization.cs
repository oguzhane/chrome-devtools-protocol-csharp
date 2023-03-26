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
    [JsonConverter(typeof(EventExecutionContextDestroyedParamsConverter))]
    public partial class EventExecutionContextDestroyedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("executionContextId"u8);
            writer.WriteNumberValue(ExecutionContextId);
            writer.WritePropertyName("executionContextUniqueId"u8);
            writer.WriteStringValue(ExecutionContextUniqueId);
            writer.WriteEndObject();
        }

        internal static EventExecutionContextDestroyedParams DeserializeEventExecutionContextDestroyedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int executionContextId = default;
            string executionContextUniqueId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("executionContextId"u8))
                {
                    executionContextId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("executionContextUniqueId"u8))
                {
                    executionContextUniqueId = property.Value.GetString();
                    continue;
                }
            }
            return new EventExecutionContextDestroyedParams(executionContextId, executionContextUniqueId);
        }

        internal partial class EventExecutionContextDestroyedParamsConverter : JsonConverter<EventExecutionContextDestroyedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventExecutionContextDestroyedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventExecutionContextDestroyedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventExecutionContextDestroyedParams(document.RootElement);
            }
        }
    }
}