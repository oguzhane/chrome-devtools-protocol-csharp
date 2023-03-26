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
    [JsonConverter(typeof(EventInterestGroupAccessedParamsConverter))]
    public partial class EventInterestGroupAccessedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("accessTime"u8);
            writer.WriteNumberValue(AccessTime);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("ownerOrigin"u8);
            writer.WriteStringValue(OwnerOrigin);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static EventInterestGroupAccessedParams DeserializeEventInterestGroupAccessedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float accessTime = default;
            string type = default;
            string ownerOrigin = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessTime"u8))
                {
                    accessTime = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerOrigin"u8))
                {
                    ownerOrigin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new EventInterestGroupAccessedParams(accessTime, type, ownerOrigin, name);
        }

        internal partial class EventInterestGroupAccessedParamsConverter : JsonConverter<EventInterestGroupAccessedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventInterestGroupAccessedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventInterestGroupAccessedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventInterestGroupAccessedParams(document.RootElement);
            }
        }
    }
}
