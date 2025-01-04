namespace PEESFPIV.Frontend.Models;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; } = null!;
    public string HashedPassword { get; set; } = null!;
    public string? Avatar { get; set; }
    public string? Name { get; set; }
}