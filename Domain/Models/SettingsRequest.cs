using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

/// <summary>
/// Запрос с настройками сайта
/// </summary>
public class SettingsRequest
{
    /// <summary>
    /// Заголовок сайта
    /// </summary>
    /// <example>
    /// Сайт фотографа
    /// </example>
    [Required, MaxLength(32)] public string SiteTitle { get; set; }
    /// <summary>
    /// Подзаголовок сайта
    /// </summary>
    /// <example>
    /// Фотографии с душой
    /// </example>
    [Required, MaxLength(256)]  public string SiteSubTitle { get; set; }
    /// <summary>
    /// Описание сайта
    /// </summary>
    /// <example>
    /// Я творю фотографии не ради денег, а ради счастья
    /// </example>
    [Required, MaxLength(2024)]  public string SiteDescription { get; set; }
    
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