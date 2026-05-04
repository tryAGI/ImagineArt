
#nullable enable

namespace ImagineArt
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Request status.<br/>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Error code.<br/>
        /// Example: 1103
        /// </summary>
        /// <example>1103</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// Error name.<br/>
        /// Example: InvalidBody
        /// </summary>
        /// <example>InvalidBody</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Error message.<br/>
        /// Example: No style was provided.
        /// </summary>
        /// <example>No style was provided.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Request status.<br/>
        /// Example: error
        /// </param>
        /// <param name="code">
        /// Error code.<br/>
        /// Example: 1103
        /// </param>
        /// <param name="error">
        /// Error name.<br/>
        /// Example: InvalidBody
        /// </param>
        /// <param name="message">
        /// Error message.<br/>
        /// Example: No style was provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            string status,
            int code,
            string error,
            string message)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Code = code;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}