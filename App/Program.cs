using App.Extensions;
using App.Extensions.Filters;
using App.Services.Auth;
using Database;
using Database.Repositories;
using Domain.Abstractions.Services.Auth;
using Domain.Models;
using Domain.Settings;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var jwtSettings = new JwtSettings(); 
var databaseSettings = new DatabaseSettings(); 

builder.Configuration.Bind(nameof(JwtSettings), jwtSettings);
builder.Configuration.Bind(nameof(DatabaseSettings), databaseSettings);

builder.Services.AddSingleton(jwtSettings);
builder.Services.AddSingleton(databaseSettings);


builder.Services.AddScoped<UsersRepository>();
builder.Services.AddScoped<SettingsRepository>();
builder.Services.AddScoped<FilesRepository>();
builder.Services.AddScoped<AlbumsRepository>();
builder.Services.AddScoped<StringsRepository>();
builder.Services.AddScoped<ReviewsRepository>();

builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddScoped<IAuthenticateService, AuthenticateService>();
builder.Services.AddScoped<IPasswordHashService, PasswordHashService>();


builder.Services.ConfigureDBContext(databaseSettings);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = "Photograph Site", 
        Version = "v1",
        Description = "Данная страница служит для тестирования API сайта для фотографа",
        Contact = new OpenApiContact
        {
            Name = "Катя Донская",
            Url = new Uri("https://vk.com/dinosaurrrrr_r"),
        },
    });
    c.OperationFilter<AddAuthHeaderOperationFilter>();
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Заголовок авторизации JWT с использованием схемы Bearer. \r\n\r\n" +
                      "Введите «Bearer» [пробел], а затем ваш токен в текстовом поле ниже" +
                      "\r\n\r\nПример: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    var xmlFileApp = $"App.xml";
    var xmlPathApp = Path.Combine(AppContext.BaseDirectory, xmlFileApp);
    c.IncludeXmlComments(xmlPathApp);
    
    var xmlFileDomain = $"Domain.xml";
    var xmlPathDomain = Path.Combine(AppContext.BaseDirectory, xmlFileDomain);
    c.IncludeXmlComments(xmlPathDomain);
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.ConfigureAuthentication(jwtSettings);
builder.Services.AddAuthorization();


var app = builder.Build();
app.UseCors(x =>
{
    x.WithOrigins("http://localhost", "https://mirea.dsvinka.ru", "http://127.0.0.1", "http://127.0.0.1:5173");
    x.AllowCredentials();
    x.AllowAnyHeader();
    x.AllowAnyMethod();
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(c =>
    {
        c.RouteTemplate = "api/docs/{documentname}/swagger.json";
    });


    app.UseSwaggerUI(c =>
    {
        c.DocumentTitle = "PhotographSite-Docs";
        c.SwaggerEndpoint("/api/docs/v1/swagger.json", "API");
        c.RoutePrefix = "docs";
    });
}
else
{
    app.UseHttpsRedirection();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope()) {
    var ctx = serviceScope.ServiceProvider.GetService<AppDbContext>();
    var passwordHashService = serviceScope.ServiceProvider.GetService<IPasswordHashService>();

    if (!ctx.Users.Any())
    {
        await ctx.Users.AddAsync(new UserModel()
        {
            FirstName = "Иван",
            FamilyName = "Иванович",
            Email = "admin@dsvinka.ru",
            PasswordHash = passwordHashService.PasswordHash("Admin"),
            Administrator = true,
        });
        await ctx.SaveChangesAsync();
    }
}

app.Run();