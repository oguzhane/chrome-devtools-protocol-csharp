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
    [JsonConverter(typeof(EventAnimationStartedParamsConverter))]
    public partial class EventAnimationStartedParams : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("animation"u8);
            writer.WriteObjectValue(Animation);
            writer.WriteEndObject();
        }

        internal static EventAnimationStartedParams DeserializeEventAnimationStartedParams(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeAnimation animation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("animation"u8))
                {
                    animation = TypeAnimation.DeserializeTypeAnimation(property.Value);
                    continue;
                }
            }
            return new EventAnimationStartedParams(animation);
        }

        internal partial class EventAnimationStartedParamsConverter : JsonConverter<EventAnimationStartedParams>
        {
            public override void Write(Utf8JsonWriter writer, EventAnimationStartedParams model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventAnimationStartedParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventAnimationStartedParams(document.RootElement);
            }
        }
    }
}
