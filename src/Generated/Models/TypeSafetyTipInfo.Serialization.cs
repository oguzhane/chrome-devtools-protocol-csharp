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
    [JsonConverter(typeof(TypeSafetyTipInfoConverter))]
    public partial class TypeSafetyTipInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("safetyTipStatus"u8);
            writer.WriteStringValue(SafetyTipStatus);
            if (Optional.IsDefined(SafeUrl))
            {
                writer.WritePropertyName("safeUrl"u8);
                writer.WriteStringValue(SafeUrl);
            }
            writer.WriteEndObject();
        }

        internal static TypeSafetyTipInfo DeserializeTypeSafetyTipInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string safetyTipStatus = default;
            Optional<string> safeUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("safetyTipStatus"u8))
                {
                    safetyTipStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("safeUrl"u8))
                {
                    safeUrl = property.Value.GetString();
                    continue;
                }
            }
            return new TypeSafetyTipInfo(safetyTipStatus, safeUrl.Value);
        }

        internal partial class TypeSafetyTipInfoConverter : JsonConverter<TypeSafetyTipInfo>
        {
            public override void Write(Utf8JsonWriter writer, TypeSafetyTipInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeSafetyTipInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeSafetyTipInfo(document.RootElement);
            }
        }
    }
}
