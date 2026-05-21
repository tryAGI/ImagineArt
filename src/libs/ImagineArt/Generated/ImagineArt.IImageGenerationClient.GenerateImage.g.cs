#nullable enable

namespace ImagineArt
{
    public partial interface IImageGenerationClient
    {
        /// <summary>
        /// Text to Image API<br/>
        /// Generate an image from a text prompt and ImagineArt style.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateImageAsync(

            global::ImagineArt.GenerateImageRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to Image API<br/>
        /// Generate an image from a text prompt and ImagineArt style.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GenerateImageAsStreamAsync(

            global::ImagineArt.GenerateImageRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to Image API<br/>
        /// Generate an image from a text prompt and ImagineArt style.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ImagineArt.AutoSDKHttpResponse<byte[]>> GenerateImageAsResponseAsync(

            global::ImagineArt.GenerateImageRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to Image API<br/>
        /// Generate an image from a text prompt and ImagineArt style.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateImageAsync(
            string prompt,
            global::ImagineArt.ImageStyle style = global::ImagineArt.ImageStyle.ImagineTurbo,
            global::ImagineArt.AspectRatio? aspectRatio = default,
            int? seed = default,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}