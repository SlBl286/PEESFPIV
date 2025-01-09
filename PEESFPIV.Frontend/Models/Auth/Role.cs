namespace PEESFPIV.Frontend.Models.Auth;

public class Role : BaseModel
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    public IEnumerable<User> Users{ get; set; } = new List<User>();
}