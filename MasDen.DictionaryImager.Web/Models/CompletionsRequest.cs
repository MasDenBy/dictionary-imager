namespace MasDen.DictionaryImager.Web.Models;

public record CompletionsRequest
{
    //public string Model { get; init; } = "meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo";
    public string Model { get; init; } = "meta-llama/Llama-3.3-70B-Instruct-Turbo-Free";
    public List<CompletionsRequestMessage> Messages { get; init; } = new();
}

public record CompletionsRequestMessage(string Role, string Content);