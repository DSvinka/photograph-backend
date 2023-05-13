using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

/// <summary>
/// Ответ с отзывом
/// </summary>
public class ReviewResponse: BaseModelResponse
{
    /// <summary>
    /// Никнейм (Логин)
    /// </summary>
    /// <example>
    /// Admin
    /// </example>
    [Required, MaxLength(1024)] public string Text { get; set; }
}