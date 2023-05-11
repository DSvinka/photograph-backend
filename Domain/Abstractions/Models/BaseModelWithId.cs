using System.ComponentModel.DataAnnotations;

namespace Domain.Abstractions.Models;

public abstract class BaseModelWithId: BaseModel
{
    [Key] public long Id { get; set; }
}