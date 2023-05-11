using Domain.Abstractions.Services.Auth;

namespace App.Services.Auth;

public class PasswordHashService: IPasswordHashService
{
    public string PasswordHash(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
	
    public bool VerifyPasswordHash(string hashedPassword, string providedPassword)
    {
        var isValid = BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword);
        return isValid;
    }
}