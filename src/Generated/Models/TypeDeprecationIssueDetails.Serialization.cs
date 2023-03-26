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
    [JsonConverter(typeof(TypeDeprecationIssueDetailsConverter))]
    public partial class TypeDeprecationIssueDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AffectedFrame))
            {
                writer.WritePropertyName("affectedFrame"u8);
                writer.WriteObjectValue(AffectedFrame);
            }
            writer.WritePropertyName("sourceCodeLocation"u8);
            writer.WriteObjectValue(SourceCodeLocation);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static TypeDeprecationIssueDetails DeserializeTypeDeprecationIssueDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TypeAffectedFrame> affectedFrame = default;
            TypeSourceCodeLocation sourceCodeLocation = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("affectedFrame"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    affectedFrame = TypeAffectedFrame.DeserializeTypeAffectedFrame(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceCodeLocation"u8))
                {
                    sourceCodeLocation = TypeSourceCodeLocation.DeserializeTypeSourceCodeLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new TypeDeprecationIssueDetails(affectedFrame.Value, sourceCodeLocation, type);
        }

        internal partial class TypeDeprecationIssueDetailsConverter : JsonConverter<TypeDeprecationIssueDetails>
        {
            public override void Write(Utf8JsonWriter writer, TypeDeprecationIssueDetails model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TypeDeprecationIssueDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTypeDeprecationIssueDetails(document.RootElement);
            }
        }
    }
}