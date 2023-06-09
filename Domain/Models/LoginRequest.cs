﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class LoginRequest
{
    [Required, EmailAddress, MaxLength(256)] public string Email { get; set; }
    [Required] public string Password { get; set; }
}