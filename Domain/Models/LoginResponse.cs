using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

public class LoginResponse: BaseModelResponse
{
    /// <summary>
    /// Никнейм (Логин)
    /// </summary>
    /// <example>
    /// Admin
    /// </example>
    [Required, MaxLength(256)] public string Username { get; set; }
    
    /// <summary>
    /// Определяет является ли пользователь администратором
    /// </summary>
    [Required] public bool Administrator { get; set; }
    
    /// <summary>
    /// Живёт мало, нужен для доступа на сайт
    /// </summary>
    [Required] public string AccessToken { get; set; }
    
    /// <summary>
    /// Refresh токен, живёт дольше чем Access, нужен для замены Access токена.
    /// </summary>
    [Required] public string RefreshToken { get; set; }
}