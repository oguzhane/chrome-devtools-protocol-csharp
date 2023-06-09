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
    [JsonConverter(typeof(TypeConnectTimingConverter))]
    public partial class TypeConnectTiming : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("requestTime"u8);
            writer.WriteNumberValue(RequestTime);
            writer.WriteEndObject();
        }

        internal static TypeConnectTiming DeserializeTypeConnectTiming(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float requestTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestTime"u8))
                {
                    requestTime = property.Value.GetSingle();
                    continue;
                }
            }
            return new TypeConnectTiming(requestTime);
        }

        internal partial class TypeConnectTimingConverter : JsonConverter<TypeConnectTiming>
        {
            public override void Write(Utf8JsonWriter writer, TypeConnectTiming model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeConnectTiming Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeConnectTiming(document.RootElement);
            }
        }
    }
}
