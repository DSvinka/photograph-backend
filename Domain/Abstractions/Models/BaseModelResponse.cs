namespace Domain.Abstractions.Models;

/// <summary>
/// Базовая запись ответа модели
/// </summary>
public abstract class BaseModelResponse
{
    /// <summary>
    /// ID записи
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    /// Дата последнего изменения записи
    /// </summary>
    public DateTime LastUpdated { get; set; }
    
    /// <summary>
    /// Дата создания записи
    /// </summary>
    public DateTime Created { get; set; }
}