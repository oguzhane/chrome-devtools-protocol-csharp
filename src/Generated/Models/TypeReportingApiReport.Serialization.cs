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
    [JsonConverter(typeof(TypeReportingApiReportConverter))]
    public partial class TypeReportingApiReport : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("initiatorUrl"u8);
            writer.WriteStringValue(InitiatorUrl);
            writer.WritePropertyName("destination"u8);
            writer.WriteStringValue(Destination);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("timestamp"u8);
            writer.WriteNumberValue(Timestamp);
            writer.WritePropertyName("depth"u8);
            writer.WriteNumberValue(Depth);
            writer.WritePropertyName("completedAttempts"u8);
            writer.WriteNumberValue(CompletedAttempts);
            writer.WritePropertyName("body"u8);
            writer.WriteObjectValue(Body);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
            writer.WriteEndObject();
        }

        internal static TypeReportingApiReport DeserializeTypeReportingApiReport(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string initiatorUrl = default;
            string destination = default;
            string type = default;
            float timestamp = default;
            int depth = default;
            int completedAttempts = default;
            object body = default;
            string status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initiatorUrl"u8))
                {
                    initiatorUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    timestamp = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("depth"u8))
                {
                    depth = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("completedAttempts"u8))
                {
                    completedAttempts = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("body"u8))
                {
                    body = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new TypeReportingApiReport(id, initiatorUrl, destination, type, timestamp, depth, completedAttempts, body, status);
        }

        internal partial class TypeReportingApiReportConverter : JsonConverter<TypeReportingApiReport>
        {
            public override void Write(Utf8JsonWriter writer, TypeReportingApiReport model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeReportingApiReport Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeReportingApiReport(document.RootElement);
            }
        }
    }
}
