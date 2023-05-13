using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class RegisterRequest
{
    [Required, MaxLength(256)] public string FirstName { get; set; }
    [MaxLength(256)] public string? FamilyName { get; set; }
    [Required, EmailAddress, MaxLength(256)] public string Email { get; set; }
    [Required] public string Password { get; set; }
}