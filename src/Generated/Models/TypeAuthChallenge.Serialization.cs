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
    [JsonConverter(typeof(TypeAuthChallengeConverter))]
    public partial class TypeAuthChallenge : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            writer.WritePropertyName("origin"u8);
            writer.WriteStringValue(Origin);
            writer.WritePropertyName("scheme"u8);
            writer.WriteStringValue(Scheme);
            writer.WritePropertyName("realm"u8);
            writer.WriteStringValue(Realm);
            writer.WriteEndObject();
        }

        internal static TypeAuthChallenge DeserializeTypeAuthChallenge(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> source = default;
            string origin = default;
            string scheme = default;
            string realm = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("origin"u8))
                {
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scheme"u8))
                {
                    scheme = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("realm"u8))
                {
                    realm = property.Value.GetString();
                    continue;
                }
            }
            return new TypeAuthChallenge(source.Value, origin, scheme, realm);
        }

        internal partial class TypeAuthChallengeConverter : JsonConverter<TypeAuthChallenge>
        {
            public override void Write(Utf8JsonWriter writer, TypeAuthChallenge model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeAuthChallenge Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeAuthChallenge(document.RootElement);
            }
        }
    }
}