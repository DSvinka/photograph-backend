using System.ComponentModel.DataAnnotations;

namespace Domain.Abstractions.Models;

public abstract class BaseModel
{
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    public DateTime Created { get; set; } = DateTime.UtcNow;
}