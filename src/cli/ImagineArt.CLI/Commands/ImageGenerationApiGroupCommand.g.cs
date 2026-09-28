#nullable enable

using System.CommandLine;

namespace ImagineArt.CLI.Commands;

internal static partial class ImageGenerationApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"image-generation", @"ImageGeneration endpoint commands.");
                         command.Subcommands.Add(ImageGenerationGenerateImageCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationGenerateTransparentImageCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}