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
    [JsonConverter(typeof(EventSubresourceWebBundleMetadataReceivedParamsConverter))]
    public partial class EventSubresourceWebBundleMetadataReceivedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("requestId"u8);
            writer.WriteStringValue(RequestId);
            writer.WritePropertyName("urls"u8);
            writer.WriteStartArray();
            foreach (var item in Urls)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static EventSubresourceWebBundleMetadataReceivedParams DeserializeEventSubresourceWebBundleMetadataReceivedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string requestId = default;
            IList<string> urls = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urls"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    urls = array;
                    continue;
                }
            }
            return new EventSubresourceWebBundleMetadataReceivedParams(requestId, urls);
        }

        internal partial class EventSubresourceWebBundleMetadataReceivedParamsConverter : JsonConverter<EventSubresourceWebBundleMetadataReceivedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventSubresourceWebBundleMetadataReceivedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventSubresourceWebBundleMetadataReceivedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventSubresourceWebBundleMetadataReceivedParams(document.RootElement);
            }
        }
    }
}
