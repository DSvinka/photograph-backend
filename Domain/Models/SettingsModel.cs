using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public class SettingsModel: BaseModelWithId
{
    [MaxLength(256)] public string BackendUrl { get; set; }
    [MaxLength(256)] public string FrontendUrl { get; set; }

    public static void InitializeEntity(ModelBuilder modelBuilder)
    {
        var userModel = modelBuilder.Entity<SettingsModel>();
        userModel.ToTable("settings");
        userModel.HasKey(b => b.Id);
        
        userModel.Property(b => b.Id)
            .IsRequired();

        userModel.Property(b => b.FrontendUrl)
            .IsRequired()
            .HasMaxLength(256);

        userModel.Property(b => b.BackendUrl)
            .IsRequired()
            .HasMaxLength(256);

        userModel.Property(b => b.LastUpdated)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValue(DateTime.UtcNow);
        
        userModel.Property(b => b.Created)
            .ValueGeneratedOnAdd()
            .HasDefaultValue(DateTime.UtcNow);
    }
}