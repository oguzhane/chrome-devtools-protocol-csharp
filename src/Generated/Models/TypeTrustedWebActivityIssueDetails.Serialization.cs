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
    [JsonConverter(typeof(TypeTrustedWebActivityIssueDetailsConverter))]
    public partial class TypeTrustedWebActivityIssueDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            writer.WritePropertyName("violationType"u8);
            writer.WriteStringValue(ViolationType);
            if (Optional.IsDefined(HttpStatusCode))
            {
                writer.WritePropertyName("httpStatusCode"u8);
                writer.WriteNumberValue(HttpStatusCode.Value);
            }
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            if (Optional.IsDefined(Signature))
            {
                writer.WritePropertyName("signature"u8);
                writer.WriteStringValue(Signature);
            }
            writer.WriteEndObject();
        }

        internal static TypeTrustedWebActivityIssueDetails DeserializeTypeTrustedWebActivityIssueDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string url = default;
            string violationType = default;
            Optional<int> httpStatusCode = default;
            Optional<string> packageName = default;
            Optional<string> signature = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("violationType"u8))
                {
                    violationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpStatusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    httpStatusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("packageName"u8))
                {
                    packageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("signature"u8))
                {
                    signature = property.Value.GetString();
                    continue;
                }
            }
            return new TypeTrustedWebActivityIssueDetails(url, violationType, Optional.ToNullable(httpStatusCode), packageName.Value, signature.Value);
        }

        internal partial class TypeTrustedWebActivityIssueDetailsConverter : JsonConverter<TypeTrustedWebActivityIssueDetails>
        {
            public override void Write(Utf8JsonWriter writer, TypeTrustedWebActivityIssueDetails model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeTrustedWebActivityIssueDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeTrustedWebActivityIssueDetails(document.RootElement);
            }
        }
    }
}
