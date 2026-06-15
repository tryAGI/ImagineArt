#nullable enable

using System.CommandLine;

namespace ImagineArt.CLI.Commands;

internal static class ImageEditingApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"image-editing", @"ImageEditing endpoint commands.");
                         command.Subcommands.Add(ImageEditingRemoveBackgroundCommandApiCommand.Create());
                         command.Subcommands.Add(ImageEditingUpscaleImageCommandApiCommand.Create());
        return command;
    }
}