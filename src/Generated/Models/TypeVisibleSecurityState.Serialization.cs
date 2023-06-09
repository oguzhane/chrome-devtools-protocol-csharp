// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    [JsonConverter(typeof(TypeVisibleSecurityStateConverter))]
    public partial class TypeVisibleSecurityState : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("securityState"u8);
            writer.WriteStringValue(SecurityState);
            if (Optional.IsDefined(CertificateSecurityState))
            {
                writer.WritePropertyName("certificateSecurityState"u8);
                writer.WriteObjectValue(CertificateSecurityState);
            }
            if (Optional.IsDefined(SafetyTipInfo))
            {
                writer.WritePropertyName("safetyTipInfo"u8);
                writer.WriteObjectValue(SafetyTipInfo);
            }
            writer.WritePropertyName("securityStateIssueIds"u8);
            writer.WriteStartArray();
            foreach (var item in SecurityStateIssueIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static TypeVisibleSecurityState DeserializeTypeVisibleSecurityState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string securityState = default;
            Optional<TypeCertificateSecurityState> certificateSecurityState = default;
            Optional<TypeSafetyTipInfo> safetyTipInfo = default;
            IList<string> securityStateIssueIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("securityState"u8))
                {
                    securityState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateSecurityState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certificateSecurityState = TypeCertificateSecurityState.DeserializeTypeCertificateSecurityState(property.Value);
                    continue;
                }
                if (property.NameEquals("safetyTipInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    safetyTipInfo = TypeSafetyTipInfo.DeserializeTypeSafetyTipInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("securityStateIssueIds"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    securityStateIssueIds = array;
                    continue;
                }
            }
            return new TypeVisibleSecurityState(securityState, certificateSecurityState.Value, safetyTipInfo.Value, securityStateIssueIds);
        }

        internal partial class TypeVisibleSecurityStateConverter : JsonConverter<TypeVisibleSecurityState>
        {
            public override void Write(Utf8JsonWriter writer, TypeVisibleSecurityState model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeVisibleSecurityState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeVisibleSecurityState(document.RootElement);
            }
        }
    }
}
