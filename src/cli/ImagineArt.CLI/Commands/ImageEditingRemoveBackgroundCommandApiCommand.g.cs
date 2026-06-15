#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace ImagineArt.CLI.Commands;

internal static partial class ImageEditingRemoveBackgroundCommandApiCommand
{
    private static Option<byte[]> Image { get; } = new(
        name: @"--image")
    {
        Description = @"Image file to process.",
        Required = true,
    };
    private static readonly ImageFileRequestOptionSet ImageFileRequestOptionSetOptions = ImageFileRequestOptionSet.Create();

    public static Command Create()
    {
        var command = new Command(@"remove-background", @"Background Remover API
Remove the background from an uploaded image.");
                        command.Options.Add(Image);                        command.Options.Add(ImageFileRequestOptionSetOptions.Imagename);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var image = parseResult.GetRequiredValue(Image);                        var imagename = parseResult.GetRequiredValue(ImageFileRequestOptionSetOptions.Imagename);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ImageEditing.RemoveBackgroundAsync(
                                    image: image,
                                    imagename: imagename,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}