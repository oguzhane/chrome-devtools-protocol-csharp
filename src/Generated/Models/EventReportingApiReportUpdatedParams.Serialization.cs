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
    [JsonConverter(typeof(EventReportingApiReportUpdatedParamsConverter))]
    public partial class EventReportingApiReportUpdatedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("report"u8);
            writer.WriteObjectValue(Report);
            writer.WriteEndObject();
        }

        internal static EventReportingApiReportUpdatedParams DeserializeEventReportingApiReportUpdatedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeReportingApiReport report = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("report"u8))
                {
                    report = TypeReportingApiReport.DeserializeTypeReportingApiReport(property.Value);
                    continue;
                }
            }
            return new EventReportingApiReportUpdatedParams(report);
        }

        internal partial class EventReportingApiReportUpdatedParamsConverter : JsonConverter<EventReportingApiReportUpdatedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventReportingApiReportUpdatedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventReportingApiReportUpdatedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventReportingApiReportUpdatedParams(document.RootElement);
            }
        }
    }
}
