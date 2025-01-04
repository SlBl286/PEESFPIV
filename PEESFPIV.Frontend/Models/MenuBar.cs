namespace PEESFPIV.Frontend.Models;

public class MenuBar
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string Link { get; set; } = "";
    public bool IsIcon { get; set; }
    public int Order { get; set; }
}