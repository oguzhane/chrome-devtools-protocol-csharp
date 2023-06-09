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
    [JsonConverter(typeof(TypeCorsErrorStatusConverter))]
    public partial class TypeCorsErrorStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("corsError"u8);
            writer.WriteStringValue(CorsError);
            writer.WritePropertyName("failedParameter"u8);
            writer.WriteStringValue(FailedParameter);
            writer.WriteEndObject();
        }

        internal static TypeCorsErrorStatus DeserializeTypeCorsErrorStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string corsError = default;
            string failedParameter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("corsError"u8))
                {
                    corsError = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failedParameter"u8))
                {
                    failedParameter = property.Value.GetString();
                    continue;
                }
            }
            return new TypeCorsErrorStatus(corsError, failedParameter);
        }

        internal partial class TypeCorsErrorStatusConverter : JsonConverter<TypeCorsErrorStatus>
        {
            public override void Write(Utf8JsonWriter writer, TypeCorsErrorStatus model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeCorsErrorStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeCorsErrorStatus(document.RootElement);
            }
        }
    }
}
