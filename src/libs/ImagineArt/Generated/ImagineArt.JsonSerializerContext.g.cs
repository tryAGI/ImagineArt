
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ImagineArt
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ImagineArt.JsonConverters.ImageStyleJsonConverter),

            typeof(global::ImagineArt.JsonConverters.ImageStyleNullableJsonConverter),

            typeof(global::ImagineArt.JsonConverters.AspectRatioJsonConverter),

            typeof(global::ImagineArt.JsonConverters.AspectRatioNullableJsonConverter),

            typeof(global::ImagineArt.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ImagineArt.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ImagineArt.GenerateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ImagineArt.ImageStyle), TypeInfoPropertyName = "ImageStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ImagineArt.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ImagineArt.GenerateTransparentImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ImagineArt.ImageFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ImagineArt.ErrorResponse))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}