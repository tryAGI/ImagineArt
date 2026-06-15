#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace ImagineArt.CLI.Commands;

internal static partial class ImageGenerationGenerateTransparentImageCommandApiCommand
{
    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text description of the transparent PNG image to generate.",
        Required = true,
    };

    private static Option<global::ImagineArt.AspectRatio?> AspectRatio { get; } = new(
        name: @"--aspect-ratio")
    {
        Description = @"Output aspect ratio.",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Optional deterministic generation seed.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

    public static Command Create()
    {
        var command = new Command(@"generate-transparent-image", @"Text to PNG API
Generate a transparent-background PNG image from a text prompt.");
                        command.Options.Add(Prompt);
                        command.Options.Add(AspectRatio);
                        command.Options.Add(Seed);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::ImagineArt.GenerateTransparentImageRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::ImagineArt.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var aspectRatio = CliRuntime.WasSpecified(parseResult, AspectRatio) ? parseResult.GetValue(AspectRatio) : __requestBase is not null ? __requestBase.AspectRatio : default;
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : __requestBase is not null ? __requestBase.Seed : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ImageGeneration.GenerateTransparentImageAsync(
                                    prompt: prompt,
                                    aspectRatio: aspectRatio,
                                    seed: seed,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}