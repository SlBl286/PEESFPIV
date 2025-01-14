namespace PEESFPIV.Frontend.Models;

public class ResearchStudy : BaseModel
{
    public string? VnTitle { get; set; }
    public string? EnTitle { get; set; }
    public string? VnDescription { get; set; }
    public string? EnDescription { get; set; }
    public string? Image { get; set; }
    public int Order { get; set; }
    public string? Link { get; set; }
}