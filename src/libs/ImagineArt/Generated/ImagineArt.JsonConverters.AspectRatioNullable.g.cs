#nullable enable

namespace ImagineArt.JsonConverters
{
    /// <inheritdoc />
    public sealed class AspectRatioNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ImagineArt.AspectRatio?>
    {
        /// <inheritdoc />
        public override global::ImagineArt.AspectRatio? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::ImagineArt.AspectRatioExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ImagineArt.AspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ImagineArt.AspectRatio?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ImagineArt.AspectRatio? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ImagineArt.AspectRatioExtensions.ToValueString(value.Value));
            }
        }
    }
}
