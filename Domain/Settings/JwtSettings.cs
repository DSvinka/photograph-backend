using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Settings;

public class JwtSettings
{
    public string SecretKey { get; set; } = string.Empty;
    
    public string Issuer { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
    
    public double AccessTokenExpirationMinutes { get; set; } = 0;
    public double RefreshTokenExpirationMinutes { get; set; } = 0;
    
    public SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));
    }
}