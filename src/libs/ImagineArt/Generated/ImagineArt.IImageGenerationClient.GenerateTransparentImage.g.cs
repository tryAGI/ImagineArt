#nullable enable

namespace ImagineArt
{
    public partial interface IImageGenerationClient
    {
        /// <summary>
        /// Text to PNG API<br/>
        /// Generate a transparent-background PNG image from a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateTransparentImageAsync(

            global::ImagineArt.GenerateTransparentImageRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to PNG API<br/>
        /// Generate a transparent-background PNG image from a text prompt.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateTransparentImageAsync(
            string prompt,
            global::ImagineArt.AspectRatio? aspectRatio = default,
            int? seed = default,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}