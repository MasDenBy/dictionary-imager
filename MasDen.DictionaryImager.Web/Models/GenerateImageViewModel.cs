namespace MasDen.DictionaryImager.Web.Models;

public class GenerateImageViewModel
{
    public string Word { get; set; } = null!;
    public string? GenerateImagePrompt { get; set; }
    public string? GenerateImageModel { get; set; }
    public int Steps { get; set; } = 4;
}
