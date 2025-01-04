using System.Security.Claims;

namespace PEESFPIV.Frontend.Models.Auth;

public record LoggedInUserModel(Guid Id, string UserName, string Name)
{
    public Claim[] ToClaims() =>
    [
       new Claim(ClaimTypes.NameIdentifier, Id.ToString()),
       new Claim(ClaimTypes.Name, UserName),
        new Claim(ClaimTypes.GivenName, Name),
    ];
}