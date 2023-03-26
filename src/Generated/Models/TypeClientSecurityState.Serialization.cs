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
    [JsonConverter(typeof(TypeClientSecurityStateConverter))]
    public partial class TypeClientSecurityState : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("initiatorIsSecureContext"u8);
            writer.WriteBooleanValue(InitiatorIsSecureContext);
            writer.WritePropertyName("initiatorIPAddressSpace"u8);
            writer.WriteStringValue(InitiatorIPAddressSpace);
            writer.WritePropertyName("privateNetworkRequestPolicy"u8);
            writer.WriteStringValue(PrivateNetworkRequestPolicy);
            writer.WriteEndObject();
        }

        internal static TypeClientSecurityState DeserializeTypeClientSecurityState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool initiatorIsSecureContext = default;
            string initiatorIPAddressSpace = default;
            string privateNetworkRequestPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initiatorIsSecureContext"u8))
                {
                    initiatorIsSecureContext = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("initiatorIPAddressSpace"u8))
                {
                    initiatorIPAddressSpace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateNetworkRequestPolicy"u8))
                {
                    privateNetworkRequestPolicy = property.Value.GetString();
                    continue;
                }
            }
            return new TypeClientSecurityState(initiatorIsSecureContext, initiatorIPAddressSpace, privateNetworkRequestPolicy);
        }

        internal partial class TypeClientSecurityStateConverter : JsonConverter<TypeClientSecurityState>
        {
            public override void Write(Utf8JsonWriter writer, TypeClientSecurityState model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeClientSecurityState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeClientSecurityState(document.RootElement);
            }
        }
    }
}
