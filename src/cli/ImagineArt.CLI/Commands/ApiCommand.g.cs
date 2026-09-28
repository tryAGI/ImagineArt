#nullable enable

using System.CommandLine;

namespace ImagineArt.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(ImageEditingApiGroupCommand.Create());
                         command.Subcommands.Add(ImageGenerationApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}