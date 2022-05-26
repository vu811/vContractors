using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using vContractors.Application.Interfaces;
using vContractors.Application.Models.Settings;
using vContractors.Application.Models.Users;
using vContractors.Domain.Entities.Identity;
using vContractors.Domain.Repositories;

namespace vContractors.Application.Services;

public class UserService : IUserService
{
    private readonly IIdentityUnitOfWork _unitOfWork;
    private readonly AppSettings _appSettings;

    public UserService(
       IIdentityUnitOfWork unitOfWork,
        IOptions<AppSettings> appSettings)
    {
        _unitOfWork = unitOfWork;
        _appSettings = appSettings.Value;
    }

    #region Public Methods
    public async Task<List<User>> GetAll()
    {
        return await _unitOfWork.Users.GetAllAsync();
    }

    public async Task<LoginResponse?> LoginAsync(LoginRequest request, string ipAddress)
    {
        var users = await GetAll();
        var user = users.FirstOrDefault(p => p.UserName == request.UserName);
        if (user == null) return null;

        var jwtToken = GenerateJwtToken(user);
        var refreshToken = GenerateRefreshToken(ipAddress);

        user.RefreshTokens.Add(refreshToken);
        _unitOfWork.Users.Update(user);
        await _unitOfWork.SaveChangesAsync();
        return new LoginResponse { Id = user.Id, UserName = user.UserName, Token = jwtToken };
    }

    public Task<LoginResponse?> RefreshToken(string token, string ipAddress)
    {
        return null;
    }
    #endregion

    #region Private Methods
    private string GenerateJwtToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
            }),
            Expires = DateTime.UtcNow.AddMinutes(15),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    private RefreshToken GenerateRefreshToken(string ipAddress)
    {
        var randomBytes = new byte[64];
        var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomBytes);
        return new RefreshToken
        {
            Token = Convert.ToBase64String(randomBytes),
            Expires = DateTime.UtcNow.AddDays(7),
            Created = DateTime.UtcNow,
            CreatedByIp = ipAddress
        };
    }
    #endregion
}
