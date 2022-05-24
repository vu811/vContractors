using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace vContractors.Domain.Entities.Identity;

public class User : IdentityUser
{
    [JsonIgnore]
    public List<RefreshToken> RefreshTokens { get; set; }
}
