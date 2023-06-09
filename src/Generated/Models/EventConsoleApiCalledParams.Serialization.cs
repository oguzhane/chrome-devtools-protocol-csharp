// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    [JsonConverter(typeof(EventConsoleApiCalledParamsConverter))]
    public partial class EventConsoleApiCalledParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("args"u8);
            writer.WriteStartArray();
            foreach (var item in Args)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("executionContextId"u8);
            writer.WriteNumberValue(ExecutionContextId);
            writer.WritePropertyName("timestamp"u8);
            writer.WriteNumberValue(Timestamp);
            if (Optional.IsDefined(StackTrace))
            {
                writer.WritePropertyName("stackTrace"u8);
                writer.WriteObjectValue(StackTrace);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WriteEndObject();
        }

        internal static EventConsoleApiCalledParams DeserializeEventConsoleApiCalledParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IList<TypeRemoteObject> args = default;
            int executionContextId = default;
            float timestamp = default;
            Optional<TypeStackTrace> stackTrace = default;
            Optional<string> context = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("args"u8))
                {
                    List<TypeRemoteObject> array = new List<TypeRemoteObject>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TypeRemoteObject.DeserializeTypeRemoteObject(item));
                    }
                    args = array;
                    continue;
                }
                if (property.NameEquals("executionContextId"u8))
                {
                    executionContextId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    timestamp = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("stackTrace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stackTrace = TypeStackTrace.DeserializeTypeStackTrace(property.Value);
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
            }
            return new EventConsoleApiCalledParams(type, args, executionContextId, timestamp, stackTrace.Value, context.Value);
        }

        internal partial class EventConsoleApiCalledParamsConverter : JsonConverter<EventConsoleApiCalledParams>
        {
            public override void Write(Utf8JsonWriter writer, EventConsoleApiCalledParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventConsoleApiCalledParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventConsoleApiCalledParams(document.RootElement);
            }
        }
    }
}
