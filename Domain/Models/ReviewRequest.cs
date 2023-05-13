using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

/// <summary>
/// Запрос с отзывом
/// </summary>
public class ReviewRequest
{
    /// <summary>
    /// Текст отзыва
    /// </summary>
    /// <example>
    /// Всё очень круто!
    /// </example>
    [Required, MaxLength(1024)] public string Text { get; set; }
}