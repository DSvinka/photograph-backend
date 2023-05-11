using System.Security.Claims;
using Database.Repositories;
using Domain.Abstractions.Services.Auth;
using Domain.Models;

namespace App.Services.Auth;

public class AuthenticateService : IAuthenticateService
{
    private readonly ITokenService _tokenService;
    private readonly UsersRepository _usersRepository;

    public AuthenticateService(UsersRepository usersRepository, ITokenService tokenService)
    {
        _tokenService = tokenService;
        _usersRepository = usersRepository;
        _tokenService = tokenService;
    }

    public async Task<TokenResponse> LoginUser(UserModel userModel)
    {
        var accessToken = _tokenService.GenerateAccessToken(userModel);
        var refreshToken = _tokenService.GenerateRefreshToken(userModel);

        userModel.RefreshToken = refreshToken;
        _usersRepository.Update(userModel);
        
        await _usersRepository.CommitAsync();

        return new TokenResponse()
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken
        };
    }

    public async Task<UserModel?> GetUser(ClaimsPrincipal user)
    {
        var userIdClaim = user.Claims.FirstOrDefault(x => x.Type == "id");
        if (userIdClaim == null)
        {
            return null;
        }
        
        var userModel = await _usersRepository.GetByIdAsync(long.Parse(userIdClaim.Value));
        return userModel;
    }
}