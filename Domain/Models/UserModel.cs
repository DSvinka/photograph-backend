using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public class UserModel: BaseModelWithId
{
    // Поля для авторизации.
    public string Username { get; set; }
    // Хранение пароля в чистом виде является плохой практикой, по этому пароли принято переводить в хеш токен.
    public string PasswordHash { get; set; }

    // Буллевое поле для отметки пользователя в качестве администратора.
    public bool Administrator { get; set; }
    
    // Поле для токен обновления.
    public string? RefreshToken { get; set; }

    public static void InitializeEntity(ModelBuilder modelBuilder)
    {
        // Получаем "строителя" модели.
        var userModel = modelBuilder.Entity<UserModel>();
        // Приписываем для модели таблицу "users".
        userModel.ToTable("users");
        // Обозначаем поле, которое является ключевым.
        userModel.HasKey(b => b.Id);
        
   
        // Поле Id:
        // - Частью сущности;
        // - Объязателен для заполнения (EF Core автоматически заполняет это поле);
        userModel.Property(b => b.Id)
            .IsRequired();

        // Поле Username:
        // - Частью сущности;
        // - Объязателен для заполнения;
        // - Имеет максимальную длинну в 256 символов;
        userModel.Property(b => b.Username)
            .IsRequired()
            .HasMaxLength(256);

        // Поле PasswordHash:
        // - Часть сущности;
        // - Объязателен для заполнения;
        userModel.Property(b => b.PasswordHash)
            .IsRequired();

        // Поле Administrator:
        // - Частью сущности;
        // - Объязателен для заполнения;
        userModel.Property(b => b.Administrator)
            .IsRequired();

        // Поле RefreshToken:
        // - Часть сущности;
        userModel.Property(b => b.RefreshToken);

        // Поле LastUpdated:
        // - Часть сущности;
        // - Значение автоматически генерируется при добавлении записи или её обновлении;
        // - По умолчанию имеет текущую дату;
        userModel.Property(b => b.LastUpdated)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValue(DateTime.UtcNow);
        
        // Поле LastUpdated:
        // - Часть сущности;
        // - Значение автоматически генерируется при добавлении записи;
        // - По умолчанию имеет текущую дату;
        userModel.Property(b => b.Created)
            .ValueGeneratedOnAdd()
            .HasDefaultValue(DateTime.UtcNow);
    }
}