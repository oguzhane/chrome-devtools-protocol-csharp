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
    [JsonConverter(typeof(TypeWebSocketRequestConverter))]
    public partial class TypeWebSocketRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("headers"u8);
            writer.WriteObjectValue(Headers);
            writer.WriteEndObject();
        }

        internal static TypeWebSocketRequest DeserializeTypeWebSocketRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object headers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headers"u8))
                {
                    headers = property.Value.GetObject();
                    continue;
                }
            }
            return new TypeWebSocketRequest(headers);
        }

        internal partial class TypeWebSocketRequestConverter : JsonConverter<TypeWebSocketRequest>
        {
            public override void Write(Utf8JsonWriter writer, TypeWebSocketRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeWebSocketRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeWebSocketRequest(document.RootElement);
            }
        }
    }
}
