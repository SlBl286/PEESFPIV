namespace PEESFPIV.Frontend.Models;

public class TrainingCourse : BaseModel
{
    public string? VnTitle{ get; set; }
    public string? EnTitle { get; set; }
    public string? VnAddress { get; set; }
    public string? EnAddress { get; set; }
    public DateTime EventDate { get; set; }
    public string? Image { get; set; }
    public string? Link { get; set; }
    public int NumOfParticipation { get; set; }
    public int Order { get; set; }
}