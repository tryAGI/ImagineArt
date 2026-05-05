#nullable enable

namespace ImagineArt
{
    public partial interface IImageEditingClient
    {
        /// <summary>
        /// Image Upscale API<br/>
        /// Upscale an uploaded image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> UpscaleImageAsync(

            global::ImagineArt.ImageFileRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Upscale API<br/>
        /// Upscale an uploaded image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> UpscaleImageAsStreamAsync(

            global::ImagineArt.ImageFileRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Upscale API<br/>
        /// Upscale an uploaded image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ImagineArt.AutoSDKHttpResponse<byte[]>> UpscaleImageAsResponseAsync(

            global::ImagineArt.ImageFileRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Upscale API<br/>
        /// Upscale an uploaded image.
        /// </summary>
        /// <param name="image">
        /// Image file to process.
        /// </param>
        /// <param name="imagename">
        /// Image file to process.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> UpscaleImageAsync(
            byte[] image,
            string imagename,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Image Upscale API<br/>
        /// Upscale an uploaded image.
        /// </summary>
        /// <param name="image">
        /// Image file to process.
        /// </param>
        /// <param name="imagename">
        /// Image file to process.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> UpscaleImageAsync(
            global::System.IO.Stream image,
            string imagename,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Upscale API<br/>
        /// Upscale an uploaded image.
        /// </summary>
        /// <param name="image">
        /// Image file to process.
        /// </param>
        /// <param name="imagename">
        /// Image file to process.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> UpscaleImageAsStreamAsync(
            global::System.IO.Stream image,
            string imagename,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Upscale API<br/>
        /// Upscale an uploaded image.
        /// </summary>
        /// <param name="image">
        /// Image file to process.
        /// </param>
        /// <param name="imagename">
        /// Image file to process.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ImagineArt.AutoSDKHttpResponse<byte[]>> UpscaleImageAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}