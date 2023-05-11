using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

/// <summary>
/// Ответ с токенами
/// </summary>
public class RefreshTokenResponse
{
    /// <summary>
    /// Живёт мало, нужен для доступа на сайт
    /// </summary>
    [Required] public string AccessToken { get; set; }
    
    /// <summary>
    /// Refresh токен, живёт дольше чем Access, нужен для замены Access токена.
    /// </summary>
    [Required] public string RefreshToken { get; set; }
}