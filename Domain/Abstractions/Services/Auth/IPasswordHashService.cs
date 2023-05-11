namespace Domain.Abstractions.Services.Auth;

public interface IPasswordHashService
{
    string PasswordHash(string password);
    bool VerifyPasswordHash(string hashedPassword, string providedPassword);
}