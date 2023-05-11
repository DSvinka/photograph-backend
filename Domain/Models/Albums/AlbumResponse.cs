using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;

namespace Domain.Models.Albums;

/// <summary>
/// Ответ с фотоальбомом
/// </summary>
public class AlbumResponse: BaseModelResponse
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
    /// Альбомное изображение
    /// </summary>
    public FileResponse CoverFile { get; set; }
    /// <summary>
    /// Файлы фотоальбома
    /// </summary>
    public List<FileResponse> Files { get; set; }
}