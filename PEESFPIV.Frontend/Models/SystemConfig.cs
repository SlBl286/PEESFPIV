namespace PEESFPIV.Frontend.Models;

public class SystemConfig : BaseModel
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public DateTime EventDate { get; set; }
    public string? Avatar { get; set; }
    public string? Link { get; set; }
    public int NumOfParticipation { get; set; }
}