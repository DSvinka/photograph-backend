using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

/// <summary>
/// Запрос с строкой
/// </summary>
public class StringRequest
{
    /// <summary>
    /// Значение
    /// </summary>
    /// <example>
    /// Реклама от наших партнёров
    /// </example>
    [Required, MaxLength(4096)]  public string Value { get; set; }
}