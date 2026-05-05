#nullable enable

namespace ImagineArt
{
    public partial interface IImageEditingClient
    {
        /// <summary>
        /// Background Remover API<br/>
        /// Remove the background from an uploaded image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> RemoveBackgroundAsync(

            global::ImagineArt.ImageFileRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Background Remover API<br/>
        /// Remove the background from an uploaded image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> RemoveBackgroundAsStreamAsync(

            global::ImagineArt.ImageFileRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Background Remover API<br/>
        /// Remove the background from an uploaded image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ImagineArt.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ImagineArt.AutoSDKHttpResponse<byte[]>> RemoveBackgroundAsResponseAsync(

            global::ImagineArt.ImageFileRequest request,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Background Remover API<br/>
        /// Remove the background from an uploaded image.
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
        global::System.Threading.Tasks.Task<byte[]> RemoveBackgroundAsync(
            byte[] image,
            string imagename,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Background Remover API<br/>
        /// Remove the background from an uploaded image.
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
        global::System.Threading.Tasks.Task<byte[]> RemoveBackgroundAsync(
            global::System.IO.Stream image,
            string imagename,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Background Remover API<br/>
        /// Remove the background from an uploaded image.
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
        global::System.Threading.Tasks.Task<global::System.IO.Stream> RemoveBackgroundAsStreamAsync(
            global::System.IO.Stream image,
            string imagename,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Background Remover API<br/>
        /// Remove the background from an uploaded image.
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
        global::System.Threading.Tasks.Task<global::ImagineArt.AutoSDKHttpResponse<byte[]>> RemoveBackgroundAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::ImagineArt.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}