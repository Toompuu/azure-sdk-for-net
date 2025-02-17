// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class InputGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("inputIds");
            writer.WriteObjectValue(InputIds);
            if (Optional.IsDefined(Position))
            {
                writer.WritePropertyName("position");
                writer.WriteObjectValue(Position);
            }
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width");
                writer.WriteObjectValue(Width);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height");
                writer.WriteObjectValue(Height);
            }
            if (Optional.IsDefined(Rows))
            {
                writer.WritePropertyName("rows");
                writer.WriteNumberValue(Rows.Value);
            }
            if (Optional.IsDefined(Columns))
            {
                writer.WritePropertyName("columns");
                writer.WriteNumberValue(Columns.Value);
            }
            if (Optional.IsDefined(Layer))
            {
                writer.WritePropertyName("layer");
                writer.WriteStringValue(Layer);
            }
            writer.WriteEndObject();
        }

        internal static InputGroup DeserializeInputGroup(JsonElement element)
        {
            object inputIds = default;
            Optional<InputPosition> position = default;
            Optional<object> width = default;
            Optional<object> height = default;
            Optional<int> rows = default;
            Optional<int> columns = default;
            Optional<string> layer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputIds"))
                {
                    inputIds = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("position"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    position = InputPosition.DeserializeInputPosition(property.Value);
                    continue;
                }
                if (property.NameEquals("width"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    width = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("height"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    height = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("rows"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rows = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    columns = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("layer"))
                {
                    layer = property.Value.GetString();
                    continue;
                }
            }
            return new InputGroup(inputIds, position.Value, width.Value, height.Value, Optional.ToNullable(rows), Optional.ToNullable(columns), layer.Value);
        }
    }
}
