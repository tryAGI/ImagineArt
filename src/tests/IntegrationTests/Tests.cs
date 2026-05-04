namespace ImagineArt.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ImagineArtClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("IMAGINEART_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("IMAGINEART_API_KEY environment variable is not found.");

        var client = new ImagineArtClient(apiKey);
        
        return client;
    }
}
