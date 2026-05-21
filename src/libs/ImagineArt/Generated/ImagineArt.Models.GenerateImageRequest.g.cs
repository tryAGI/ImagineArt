
#nullable enable

namespace ImagineArt
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageRequest
    {
        /// <summary>
        /// Text description of the image to generate.<br/>
        /// Example: A futuristic cityscape at night with neon lights
        /// </summary>
        /// <example>A futuristic cityscape at night with neon lights</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// ImagineArt style identifier.<br/>
        /// Default Value: imagine-turbo
        /// </summary>
        /// <default>global::ImagineArt.ImageStyle.ImagineTurbo</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ImagineArt.JsonConverters.ImageStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ImagineArt.ImageStyle Style { get; set; } = global::ImagineArt.ImageStyle.ImagineTurbo;

        /// <summary>
        /// Output aspect ratio.<br/>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ImagineArt.JsonConverters.AspectRatioJsonConverter))]
        public global::ImagineArt.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Optional deterministic generation seed.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text description of the image to generate.<br/>
        /// Example: A futuristic cityscape at night with neon lights
        /// </param>
        /// <param name="style">
        /// ImagineArt style identifier.<br/>
        /// Default Value: imagine-turbo
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio.<br/>
        /// Default Value: 1:1
        /// </param>
        /// <param name="seed">
        /// Optional deterministic generation seed.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequest(
            string prompt,
            global::ImagineArt.ImageStyle style,
            global::ImagineArt.AspectRatio? aspectRatio,
            int? seed)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Style = style;
            this.AspectRatio = aspectRatio;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        public GenerateImageRequest()
        {
        }

    }
}