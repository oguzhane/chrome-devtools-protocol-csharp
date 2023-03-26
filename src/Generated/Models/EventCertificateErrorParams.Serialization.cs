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
    [JsonConverter(typeof(EventCertificateErrorParamsConverter))]
    public partial class EventCertificateErrorParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("eventId"u8);
            writer.WriteNumberValue(EventId);
            writer.WritePropertyName("errorType"u8);
            writer.WriteStringValue(ErrorType);
            writer.WritePropertyName("requestURL"u8);
            writer.WriteStringValue(RequestURL);
            writer.WriteEndObject();
        }

        internal static EventCertificateErrorParams DeserializeEventCertificateErrorParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int eventId = default;
            string errorType = default;
            string requestURL = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventId"u8))
                {
                    eventId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorType"u8))
                {
                    errorType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestURL"u8))
                {
                    requestURL = property.Value.GetString();
                    continue;
                }
            }
            return new EventCertificateErrorParams(eventId, errorType, requestURL);
        }

        internal partial class EventCertificateErrorParamsConverter : JsonConverter<EventCertificateErrorParams>
        {
            public override void Write(Utf8JsonWriter writer, EventCertificateErrorParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventCertificateErrorParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventCertificateErrorParams(document.RootElement);
            }
        }
    }
}
