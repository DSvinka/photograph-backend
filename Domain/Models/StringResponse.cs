using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

/// <summary>
/// Ответ с строкой
/// </summary>
public class StringResponse: BaseModelResponse
{
    /// <summary>
    /// Ключ
    /// </summary>
    /// <example>
    /// advertTitle
    /// </example>
    [Required, MaxLength(32)] public string Key { get; set; }
    /// <summary>
    /// Значение
    /// </summary>
    /// <example>
    /// Реклама от наших партнёров
    /// </example>
    [Required, MaxLength(4096)] public string Value { get; set; }
}