using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

/// <summary>
/// Запрос с Refresh токеном
/// </summary>
public class RefreshTokenRequest
{
    /// <summary>
    /// Refresh токен, живёт дольше чем Access, нужен для замены Access токена.
    /// </summary>
    [Required] public string RefreshToken { get; set; }
}