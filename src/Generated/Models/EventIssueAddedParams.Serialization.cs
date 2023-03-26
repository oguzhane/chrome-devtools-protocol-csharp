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
    [JsonConverter(typeof(EventIssueAddedParamsConverter))]
    public partial class EventIssueAddedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("issue"u8);
            writer.WriteObjectValue(Issue);
            writer.WriteEndObject();
        }

        internal static EventIssueAddedParams DeserializeEventIssueAddedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeInspectorIssue issue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issue"u8))
                {
                    issue = TypeInspectorIssue.DeserializeTypeInspectorIssue(property.Value);
                    continue;
                }
            }
            return new EventIssueAddedParams(issue);
        }

        internal partial class EventIssueAddedParamsConverter : JsonConverter<EventIssueAddedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventIssueAddedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventIssueAddedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventIssueAddedParams(document.RootElement);
            }
        }
    }
}
