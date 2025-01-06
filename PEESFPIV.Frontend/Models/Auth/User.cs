using System.Security.Claims;

namespace PEESFPIV.Frontend.Models.Auth;

public sealed class User : BaseModel
{
    public string Username { get; set; } = null!;
    public string? Name { get; set; }
    public string? Avatar { get; set; }
    public string HashedPassword { get; set; } = null!;
    public string Salt { get; set; } = null!;
    public Claim[] ToClaims() =>
    [
       new Claim(ClaimTypes.NameIdentifier, Id.ToString()),
       new Claim(ClaimTypes.Name, Username),
        new Claim(ClaimTypes.GivenName, Name ?? ""),
    ];
}