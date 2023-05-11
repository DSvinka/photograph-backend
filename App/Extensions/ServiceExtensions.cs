using Database;
using Domain.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace App.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureDBContext(this IServiceCollection services, DatabaseSettings databaseSettings)
    {
        services.AddDbContext<AppDbContext>(options => {
            options.UseNpgsql(databaseSettings.DatabaseConnection);
        });
    }

    public static void ConfigureAuthentication(this IServiceCollection services, JwtSettings jwtSettings)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(x =>
        {
            x.RequireHttpsMetadata = false;
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateLifetime = true,
                
                ValidateIssuer = true,
                ValidIssuer = jwtSettings.Issuer,
                
                ValidateAudience = true,
                ValidAudience = jwtSettings.Audience,
                
                IssuerSigningKey = jwtSettings.GetSymmetricSecurityKey(),
                ValidateIssuerSigningKey = true,
            };
        });
    }
}