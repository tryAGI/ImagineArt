#nullable enable

using System.CommandLine;
using ImagineArt.CLI;
using ImagineArt.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the ImagineArt SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(ImageEditingApiGroupCommand.Create());
rootCommand.Subcommands.Add(ImageGenerationApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);