using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

/// <summary>
/// Запрос на загрузку файла
/// </summary>
public class FileRequest
{
    /// <summary>
    /// Имя файла
    /// </summary>
    /// <example>
    /// file_image_2022
    /// </example>
    [Required, MaxLength(32)] public string FileName { get; set; }
    /// <summary>
    /// Тип файла
    /// </summary>
    /// <example>
    /// png
    /// </example>
    [Required, MaxLength(6)] public string FileType { get; set; }
    /// <summary>
    /// Байты файла
    /// </summary>
    [Required] public byte[] FileBytes { get; set; }
    
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
}