using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

/// <summary>
/// Ответ со всеми строками
/// </summary>
public class StringsResponse
{
    /// <summary>
    /// Словарь со значениями
    /// </summary>
    /// <example>
    /// {
    ///     "advertTitle": "Реклама от наших партнёров",
    ///     "postsTitle": "Посты"
    /// }
    /// </example>
    [Required] public Dictionary<string, string> Strings { get; set; }
}