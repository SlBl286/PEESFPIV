namespace PEESFPIV.Frontend.Models;

public class SystemConfig : BaseModel
{
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? VnValue { get; set; }
    public string? EnValue { get; set; }
    public string? GroupCode { get; set; }
}