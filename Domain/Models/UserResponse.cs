using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

/// <summary>
/// Ответ с пользователем
/// </summary>
public class UserResponse: BaseModelResponse
{
    /// <summary>
    /// Никнейм (Логин)
    /// </summary>
    /// <example>
    /// Admin
    /// </example>
    [Required, MaxLength(256)] public string Username { get; set; }
    
    /// <summary>
    /// Статус администратора
    /// </summary>
    [Required] public bool Administrator { get; set; }
}