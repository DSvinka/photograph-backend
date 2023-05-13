using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public class UserModel: BaseModelWithId
{
    public string FirstName { get; set; }
    public string? FamilyName { get; set; }
    
    /// <summary>
    /// Адрес электронной почты (Email)
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Хеш пароля
    /// </summary>
    public string PasswordHash { get; set; }

    /// <summary>
    /// Является ли пользователем администратором?
    /// </summary>
    public bool Administrator { get; set; }
    
    /// <summary>
    /// Токен обновления, для обновления токена авторизации
    /// </summary>
    public string? RefreshToken { get; set; }
    
    /// <summary>
    /// Модель отзыва
    /// </summary>
    public ReviewModel? Review { get; set; }

    public static void InitializeEntity(ModelBuilder modelBuilder)
    {
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

        // Поле FirstName:
        // - Частью сущности;
        // - Объязателен для заполнения;
        // - Имеет максимальную длинну в 256 символов;
        userModel.Property(b => b.FirstName)
            .IsRequired()
            .HasMaxLength(256);
        
        // Поле SecondName:
        // - Частью сущности;
        // - Не объязателен для заполнения;
        // - Имеет максимальную длинну в 256 символов;
        userModel.Property(b => b.FamilyName)
            .HasMaxLength(256);
        
        // Поле Email:
        // - Частью сущности;
        // - Объязателен для заполнения;
        // - Имеет максимальную длинну в 256 символов;
        userModel.Property(b => b.Email)
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