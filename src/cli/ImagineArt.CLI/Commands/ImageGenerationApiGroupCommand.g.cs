#nullable enable

using System.CommandLine;

namespace ImagineArt.CLI.Commands;

internal static class ImageGenerationApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"image-generation", @"ImageGeneration endpoint commands.");
                         command.Subcommands.Add(ImageGenerationGenerateImageCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationGenerateTransparentImageCommandApiCommand.Create());
        return command;
    }
}