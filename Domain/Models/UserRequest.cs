using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

/// <summary>
/// Запрос с пользователем
/// </summary>
public class UserRequest
{
    /// <summary>
    /// Никнейм (Логин)
    /// </summary>
    /// <example>
    /// Admin
    /// </example>
    [Required, MaxLength(256)] public string Username { get; set; }
    
    /// <summary>
    /// Пароль. Не указывайте это поле если не хотите менять пароль
    /// </summary>
    /// <example>
    /// ItsHardPassword
    /// </example>
    public string? Password { get; set; }

    /// <summary>
    /// Определяет является ли пользователь администратором
    /// </summary>
    [Required] public bool Administrator { get; set; }
}