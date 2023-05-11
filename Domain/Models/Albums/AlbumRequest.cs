using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Albums;

/// <summary>
/// Запрос с Фотоальбомом
/// </summary>
public class AlbumRequest
{
    /// <summary>
    /// Надпись на кнопки
    /// </summary>
    /// <example>
    /// Семейное
    /// </example>
    [Required, MaxLength(256)] public string ButtonName { get; set; }
    
    /// <summary>
    /// Заголовок
    /// </summary>
    /// <example>
    /// Семейные фотографии
    /// </example>
    [Required, MaxLength(512)] public string Title { get; set; }
    /// <summary>
    /// Описание
    /// </summary>
    /// <example>
    /// Семейные фотографии в чёрнобелом стиле, в студии с большими окнами
    /// </example>
    [Required, MaxLength(2024)] public string Description { get; set; }
    
    /// <summary>
    /// Высота обложки
    /// </summary>
    /// <example>
    /// 1080
    /// </example>
    public int? CoverFileHeight { get; set; }
    
    /// <summary>
    /// Ширина обложки
    /// </summary>
    /// <example>
    /// 1920
    /// </example>
    public int? CoverFileWidth { get; set; }
    
    /// <summary>
    /// Имя обложки
    /// </summary>
    /// <example>
    /// file_image_2022
    /// </example>
    [MaxLength(32)] public string? CoverFileName { get; set; }
    /// <summary>
    /// Тип обложки
    /// </summary>
    /// <example>
    /// png
    /// </example>
    [MaxLength(32)] public string? CoverFileType { get; set; }
    /// <summary>
    /// Байты обложки
    /// </summary>
    public byte[]? CoverFileBytes { get; set; }
}