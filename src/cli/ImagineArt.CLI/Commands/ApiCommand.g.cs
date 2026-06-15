#nullable enable

using System.CommandLine;

namespace ImagineArt.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(ImageEditingApiGroupCommand.Create());
                         command.Subcommands.Add(ImageGenerationApiGroupCommand.Create());
        return command;
    }
}