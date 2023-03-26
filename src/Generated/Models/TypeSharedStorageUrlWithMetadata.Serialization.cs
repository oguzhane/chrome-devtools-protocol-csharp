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
    [JsonConverter(typeof(TypeSharedStorageUrlWithMetadataConverter))]
    public partial class TypeSharedStorageUrlWithMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            writer.WritePropertyName("reportingMetadata"u8);
            writer.WriteStartArray();
            foreach (var item in ReportingMetadata)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static TypeSharedStorageUrlWithMetadata DeserializeTypeSharedStorageUrlWithMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string url = default;
            IList<TypeSharedStorageReportingMetadata> reportingMetadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportingMetadata"u8))
                {
                    List<TypeSharedStorageReportingMetadata> array = new List<TypeSharedStorageReportingMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TypeSharedStorageReportingMetadata.DeserializeTypeSharedStorageReportingMetadata(item));
                    }
                    reportingMetadata = array;
                    continue;
                }
            }
            return new TypeSharedStorageUrlWithMetadata(url, reportingMetadata);
        }

        internal partial class TypeSharedStorageUrlWithMetadataConverter : JsonConverter<TypeSharedStorageUrlWithMetadata>
        {
            public override void Write(Utf8JsonWriter writer, TypeSharedStorageUrlWithMetadata model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeSharedStorageUrlWithMetadata Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeSharedStorageUrlWithMetadata(document.RootElement);
            }
        }
    }
}