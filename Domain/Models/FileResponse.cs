using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

/// <summary>
/// Ответ с файлом
/// </summary>
public class FileResponse
{
    /// <summary>
    /// ID Записи
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    /// Имя файла + Тип файла
    /// </summary>
    /// <example>
    /// file_image_2022.png
    /// </example>
    [Required, MaxLength(32)] public string Filename { get; set; }
    
    /// <summary>
    /// Высота
    /// </summary>
    /// <example>
    /// 1080
    /// </example>
    [Required] public int Height { get; set; }
    
    /// <summary>
    /// Ширина
    /// </summary>
    /// <example>
    /// 1920
    /// </example>
    [Required] public int Width { get; set; }
    
    /// <summary>
    /// Ссылка на файл
    /// </summary>
    /// <example>
    /// https://mirea.dsvinka.ru/api/files/file_image_2022.png
    /// </example>
    [Required] public string Url { get; set; }
}