using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class LoginRequest
{
    [Required, MaxLength(256)] public string Username { get; set; }
    [Required] public string Password { get; set; }
}