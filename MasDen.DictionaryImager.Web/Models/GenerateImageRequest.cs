using System.Text.Json.Serialization;

namespace MasDen.DictionaryImager.Web.Models;

public record GenerateImageRequest
{
    public GenerateImageRequest(string prompt)
    {
        Prompt = "[" + prompt + "]";
    }

    public string Model { get; init; } = "black-forest-labs/FLUX.1-schnell-Free";
    public string Prompt { get; private set; }
    public int Width { get; init; } = 400;
    public int Height { get; init; } = 400;
    public int Steps { get; init; } = 4;
    public int N { get; init; } = 1;

    [JsonPropertyName("response_format")]
    public string ResponseFormat { get; init; } = "b64_json";
}
