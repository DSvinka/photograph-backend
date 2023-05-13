using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

public class LoginResponse: BaseModelResponse
{
    /// <summary>
    /// Адрес электронной почты (Логин)
    /// </summary>
    /// <example>
    /// example@dsvinka.ru
    /// </example>
    [Required, EmailAddress, MaxLength(256)] public string Email { get; set; }
    
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