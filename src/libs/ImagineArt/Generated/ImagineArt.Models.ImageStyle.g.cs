
#nullable enable

namespace ImagineArt
{
    /// <summary>
    /// ImagineArt style identifier.<br/>
    /// Default Value: imagine-turbo
    /// </summary>
    public enum ImageStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Anime,
        /// <summary>
        /// 
        /// </summary>
        FluxDev,
        /// <summary>
        /// 
        /// </summary>
        FluxDevFast,
        /// <summary>
        /// 
        /// </summary>
        FluxSchnell,
        /// <summary>
        /// 
        /// </summary>
        ImagineTurbo,
        /// <summary>
        /// 
        /// </summary>
        Realistic,
        /// <summary>
        /// 
        /// </summary>
        Sdxl10,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageStyle value)
        {
            return value switch
            {
                ImageStyle.Anime => "anime",
                ImageStyle.FluxDev => "flux-dev",
                ImageStyle.FluxDevFast => "flux-dev-fast",
                ImageStyle.FluxSchnell => "flux-schnell",
                ImageStyle.ImagineTurbo => "imagine-turbo",
                ImageStyle.Realistic => "realistic",
                ImageStyle.Sdxl10 => "sdxl-1.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageStyle? ToEnum(string value)
        {
            return value switch
            {
                "anime" => ImageStyle.Anime,
                "flux-dev" => ImageStyle.FluxDev,
                "flux-dev-fast" => ImageStyle.FluxDevFast,
                "flux-schnell" => ImageStyle.FluxSchnell,
                "imagine-turbo" => ImageStyle.ImagineTurbo,
                "realistic" => ImageStyle.Realistic,
                "sdxl-1.0" => ImageStyle.Sdxl10,
                _ => null,
            };
        }
    }
}