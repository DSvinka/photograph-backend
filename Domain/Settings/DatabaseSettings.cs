using System.ComponentModel.DataAnnotations;

namespace Domain.Settings;

public class DatabaseSettings
{
    [Required] public string DatabaseConnection { get; set; }
}