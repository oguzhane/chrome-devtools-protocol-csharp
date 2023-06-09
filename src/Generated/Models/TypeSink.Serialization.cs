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
    [JsonConverter(typeof(TypeSinkConverter))]
    public partial class TypeSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Session))
            {
                writer.WritePropertyName("session"u8);
                writer.WriteStringValue(Session);
            }
            writer.WriteEndObject();
        }

        internal static TypeSink DeserializeTypeSink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string id = default;
            Optional<string> session = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("session"u8))
                {
                    session = property.Value.GetString();
                    continue;
                }
            }
            return new TypeSink(name, id, session.Value);
        }

        internal partial class TypeSinkConverter : JsonConverter<TypeSink>
        {
            public override void Write(Utf8JsonWriter writer, TypeSink model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeSink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeSink(document.RootElement);
            }
        }
    }
}
