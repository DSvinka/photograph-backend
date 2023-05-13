using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

/// <summary>
/// Ответ с пользователем
/// </summary>
public class UserWithReviewResponse: UserResponse
{
    /// <summary>
    /// Отзыв
    /// </summary>
    [Required] public ReviewResponse? Review { get; set; }
}