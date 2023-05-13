using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

public class RegisterResponse: BaseModelResponse
{
    /// <summary>
    /// Имя
    /// </summary>
    /// <example>
    /// Иван
    /// </example>
    [Required, MaxLength(256)] public string FirstName { get; set; }
    
    /// <summary>
    /// Фамилия
    /// </summary>
    /// <example>
    /// Иванов
    /// </example>
    [Required, MaxLength(256)] public string FamilyName { get; set; }
    
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
}