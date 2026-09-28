#nullable enable

using System.CommandLine;

namespace ImagineArt.CLI.Commands;

internal static partial class ImageEditingApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"image-editing", @"ImageEditing endpoint commands.");
                         command.Subcommands.Add(ImageEditingRemoveBackgroundCommandApiCommand.Create());
                         command.Subcommands.Add(ImageEditingUpscaleImageCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}