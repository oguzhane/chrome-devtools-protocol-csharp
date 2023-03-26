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
    [JsonConverter(typeof(EventWindowOpenParamsConverter))]
    public partial class EventWindowOpenParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            writer.WritePropertyName("windowName"u8);
            writer.WriteStringValue(WindowName);
            writer.WritePropertyName("windowFeatures"u8);
            writer.WriteStartArray();
            foreach (var item in WindowFeatures)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("userGesture"u8);
            writer.WriteBooleanValue(UserGesture);
            writer.WriteEndObject();
        }

        internal static EventWindowOpenParams DeserializeEventWindowOpenParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string url = default;
            string windowName = default;
            IList<string> windowFeatures = default;
            bool userGesture = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowName"u8))
                {
                    windowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowFeatures"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    windowFeatures = array;
                    continue;
                }
                if (property.NameEquals("userGesture"u8))
                {
                    userGesture = property.Value.GetBoolean();
                    continue;
                }
            }
            return new EventWindowOpenParams(url, windowName, windowFeatures, userGesture);
        }

        internal partial class EventWindowOpenParamsConverter : JsonConverter<EventWindowOpenParams>
        {
            public override void Write(Utf8JsonWriter writer, EventWindowOpenParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventWindowOpenParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventWindowOpenParams(document.RootElement);
            }
        }
    }
}