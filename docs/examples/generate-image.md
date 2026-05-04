# Generate image

Generate an image with ImagineArt.

This example assumes `using ImagineArt;` is in scope and `apiKey` contains your ImagineArt API key.

```csharp
using var client = new ImagineArtClient(apiKey);

var image = await client.ImageGeneration.GenerateImageAsync(
    prompt: "A clean editorial product photo of a matte ceramic espresso cup.",
    style: ImageStyle.ImagineTurbo,
    aspectRatio: AspectRatio.x1_1);
```