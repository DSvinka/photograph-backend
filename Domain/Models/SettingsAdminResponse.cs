using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models;

/// <summary>
/// Ответ с публичными + администраторскими настройками сайта
/// </summary>
public class SettingsAdminResponse: BaseModelResponse
{
    /// <summary>
    /// URL бекенда
    /// </summary>
    /// <example>
    /// https://mirea.dsvinka.ru/api
    /// </example>
    [Required, MaxLength(256)] public string BackendUrl { get; set; }
    /// <summary>
    /// URL фронтенда
    /// </summary>
    /// <example>
    /// https://mirea.dsvinka.ru
    /// </example>
    [Required, MaxLength(256)] public string FrontendUrl { get; set; }
}