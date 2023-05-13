using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

/// <summary>
/// Ответ с отзывом
/// </summary>
public class ReviewWithUserResponse: ReviewResponse
{
    /// <summary>
    /// Пользователь
    /// </summary>
    [Required] public UserResponse User { get; set; }
}