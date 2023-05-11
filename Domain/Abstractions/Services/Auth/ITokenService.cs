using Domain.Models;

namespace Domain.Abstractions.Services.Auth;

public interface ITokenService
{
    public string GenerateAccessToken(UserModel userModel);
    public string GenerateRefreshToken(UserModel userModel);
}