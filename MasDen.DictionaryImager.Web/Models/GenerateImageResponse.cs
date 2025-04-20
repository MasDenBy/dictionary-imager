using System.Text.Json.Serialization;

namespace MasDen.DictionaryImager.Web.Models;

public record GenerateImageResponse
{
    public GenerateImageResponseData[] Data { get; set; } = null!;
}

public record GenerateImageResponseData
{
    [JsonPropertyName("b64_json")]
    public string? Image { get; set; }
}
