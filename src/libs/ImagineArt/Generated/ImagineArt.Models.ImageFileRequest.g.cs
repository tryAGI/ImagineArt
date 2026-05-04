
#nullable enable

namespace ImagineArt
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageFileRequest
    {
        /// <summary>
        /// Image file to process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// Image file to process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFileRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// Image file to process.
        /// </param>
        /// <param name="imagename">
        /// Image file to process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageFileRequest(
            byte[] image,
            string imagename)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFileRequest" /> class.
        /// </summary>
        public ImageFileRequest()
        {
        }
    }
}