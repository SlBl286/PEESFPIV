namespace PEESFPIV.Frontend.Models;

public class Objective : BaseModel
{
    public string VnName { get; set; } = "";
    public string VnDescription { get; set; } = "";
    public string EnName { get; set; } = "";
    public string EnDescription { get; set; } = "";
    public int Order { get; set; }
}