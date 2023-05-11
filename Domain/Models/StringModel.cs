using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public class StringModel: BaseModel
{
    [MaxLength(32)] public string Key { get; set; }
    [MaxLength(4096)]  public string Value { get; set; }

    public static void InitializeEntity(ModelBuilder modelBuilder)
    {
        var userModel = modelBuilder.Entity<StringModel>();
        userModel.ToTable("strings");
        userModel.HasKey(b => b.Key);

        userModel.Property(b => b.Key)
            .IsRequired()
            .HasMaxLength(32);
        
        userModel.Property(b => b.Value)
            .IsRequired()
            .HasMaxLength(4096);

        userModel.Property(b => b.LastUpdated)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValue(DateTime.UtcNow);
        
        userModel.Property(b => b.Created)
            .ValueGeneratedOnAdd()
            .HasDefaultValue(DateTime.UtcNow);
    }
}