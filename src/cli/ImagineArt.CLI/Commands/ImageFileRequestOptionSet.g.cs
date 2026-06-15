#nullable enable

using System.CommandLine;

namespace ImagineArt.CLI.Commands;

internal sealed record ImageFileRequestOptionSet(
    Option<string> Imagename)
{
    public static ImageFileRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ImageFileRequestOptionSet(
                        Imagename: new Option<string>($"--{normalizedPrefix}imagename")
                {
                    Description = @"Image file to process.",
                    Required = true,
                }
        );
    }
}