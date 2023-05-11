using System.Security.Claims;
using Domain.Models;

namespace Domain.Abstractions.Services.Auth;

public interface IAuthenticateService
{
    public Task<TokenResponse> LoginUser(UserModel userModel);

    public Task<UserModel?> GetUser(ClaimsPrincipal user);
}