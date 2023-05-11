using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Domain.Abstractions.Services.Auth;
using Domain.Models;
using Domain.Settings;
using Microsoft.IdentityModel.Tokens;

namespace App.Services.Auth;

public sealed class TokenService: ITokenService
{
    private readonly JwtSettings _jwtSettings;

    public TokenService(JwtSettings jwtSettings)
    {
        _jwtSettings = jwtSettings;
    }

    /// <summary>
    /// Генерирует токен доступа
    /// </summary>
    /// <param name="userModel">Пользователь</param>
    /// <returns>Токен доступа</returns>
    public string GenerateAccessToken(UserModel userModel)
    {
        // Создаём Claims в которые записываем идентификатор и для надежности никнейм (так как он тоже становится частью шифрования и тем самым усложняет расшифровку для злоумышлеников)
        var claims = new List<Claim>
        {
            new Claim("id", userModel.Id.ToString()),
            new Claim(ClaimsIdentity.DefaultNameClaimType, userModel.Username)
        };
        
        // Генерирует и возвращаем токен
        return GenerateToken(
            _jwtSettings,
            _jwtSettings.AccessTokenExpirationMinutes, 
            claims
        );
    }
    
    /// <summary>
    /// Генерирует токен обновления
    /// </summary>
    /// <param name="userModel">Пользователь</param>
    /// <returns>Токен обновления</returns>
    public string GenerateRefreshToken(UserModel userModel)
    {
        // Генерирует и возвращаем токен
        return GenerateToken(
            _jwtSettings,
            _jwtSettings.RefreshTokenExpirationMinutes
        );
    }
    
    /// <summary>
    /// Генерирует любой токен который требуется.
    /// </summary>
    /// <param name="settings">Настройки генерации токенов</param>
    /// <param name="expires">Время истечения (в минутах)</param>
    /// <param name="claims">Список из Claim объектов (не объязательное поле)</param>
    /// <returns></returns>
    private string GenerateToken(JwtSettings settings, double expires, IEnumerable<Claim>? claims = null)
    {
        var securityToken = new JwtSecurityToken(
            issuer: settings.Issuer,
            audience: settings.Audience,
            notBefore: DateTime.UtcNow,
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(expires)),
            signingCredentials: new SigningCredentials(settings.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
        
        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}