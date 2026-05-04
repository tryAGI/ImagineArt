/*
order: 10
title: Generate image
slug: generate-image

Generate an image with ImagineArt.
*/

namespace ImagineArt.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateImage()
    {
        using var client = GetAuthenticatedClient();

        var image = await client.ImageGeneration.GenerateImageAsync(
            prompt: "A clean editorial product photo of a matte ceramic espresso cup.",
            style: ImageStyle.ImagineTurbo,
            aspectRatio: AspectRatio.x1_1);

        image.Should().NotBeEmpty();
    }
}
