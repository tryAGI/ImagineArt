
#nullable enable

namespace ImagineArt
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateTransparentImageRequest
    {
        /// <summary>
        /// Text description of the transparent PNG image to generate.<br/>
        /// Example: A sleek futuristic car with glowing LED lights
        /// </summary>
        /// <example>A sleek futuristic car with glowing LED lights</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Output aspect ratio.<br/>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ImagineArt.JsonConverters.AspectRatioJsonConverter))]
        public global::ImagineArt.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Optional deterministic generation seed.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTransparentImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text description of the transparent PNG image to generate.<br/>
        /// Example: A sleek futuristic car with glowing LED lights
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio.<br/>
        /// Default Value: 1:1
        /// </param>
        /// <param name="seed">
        /// Optional deterministic generation seed.<br/>
        /// Example: 12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateTransparentImageRequest(
            string prompt,
            global::ImagineArt.AspectRatio? aspectRatio,
            int? seed)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTransparentImageRequest" /> class.
        /// </summary>
        public GenerateTransparentImageRequest()
        {
        }
    }
}