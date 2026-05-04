#nullable enable

namespace ImagineArt.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageStyleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ImagineArt.ImageStyle?>
    {
        /// <inheritdoc />
        public override global::ImagineArt.ImageStyle? Read(
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
                        return global::ImagineArt.ImageStyleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ImagineArt.ImageStyle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ImagineArt.ImageStyle?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ImagineArt.ImageStyle? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ImagineArt.ImageStyleExtensions.ToValueString(value.Value));
            }
        }
    }
}
