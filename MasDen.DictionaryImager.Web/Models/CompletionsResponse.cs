namespace MasDen.DictionaryImager.Web.Models;

public record CompletionsResponse
{
    public string Id { get; init; } = null!;
    public string Object { get; init; } = null!;
    public long Created { get; init; }
    public string Model { get; init; } = null!;
    public List<CompletionsResponseChoice> Choices { get; init; } = new();
    public CompletionsResponseUsage Usage { get; init; } = null!;
}

public record CompletionsResponseChoice
{
    public int Index { get; init; }
    public CompletionsResponseChoiceMessage Message { get; init; } = null!;
    public string FinishReason { get; init; } = null!;
}

public record CompletionsResponseChoiceMessage(string Role, string Content);
public record CompletionsResponseUsage
{
    public int PromptTokens { get; init; }
    public int CompletionTokens { get; init; }
    public int TotalTokens { get; init; }
}