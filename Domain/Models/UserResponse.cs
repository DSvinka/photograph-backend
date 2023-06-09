﻿using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

/// <summary>
/// Ответ с пользователем
/// </summary>
public class UserResponse: BaseModelResponse
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
    [Required, MaxLength(256)] public string SecondName { get; set; }
    
    /// <summary>
    /// Email (Логин)
    /// </summary>
    /// <example>
    /// Admin
    /// </example>
    [Required, MaxLength(256)] public string Email { get; set; }
    
    /// <summary>
    /// Статус администратора
    /// </summary>
    [Required] public bool Administrator { get; set; }
    
    /// <summary>
    /// Отзыв
    /// </summary>
    [Required] public ReviewResponse? Review { get; set; }
}