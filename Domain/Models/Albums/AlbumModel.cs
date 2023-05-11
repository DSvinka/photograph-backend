using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models.Albums;

public class AlbumModel: BaseModelWithId
{
    [MaxLength(256)] public string ButtonName { get; set; }
    
    [MaxLength(512)] public string Title { get; set; }
    [MaxLength(2024)] public string Description { get; set; }
    
    public long CoverFileId { get; set; }
    public FileModel CoverFile { get; set; } 
        
    public List<AlbumFileRelation> Files { get; set; }

    public static void InitializeEntity(ModelBuilder modelBuilder)
    {
        var userModel = modelBuilder.Entity<AlbumModel>();
        userModel.ToTable("albums");
        userModel.HasKey(b => b.Id);
        
        userModel.Property(b => b.Id)
            .IsRequired();

        userModel.Property(b => b.ButtonName)
            .HasMaxLength(256)
            .IsRequired();

        userModel.Property(b => b.Title)
            .IsRequired()
            .HasMaxLength(512);

        userModel.Property(b => b.Description)
            .IsRequired()
            .HasMaxLength(2024);

        // Поле CoverFile:
        // - Имеет связь "Один-ко-Одному"
        userModel.HasOne(b => b.CoverFile)
            // - Не является "Один-ко-Многим" (так как в WithMany не написаны входные данные)
            .WithMany()
            // - В качестве ключа для поддержания связи использует поле CoverFileId
            .HasForeignKey(p => p.CoverFileId);

        userModel.Property(b => b.LastUpdated)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValue(DateTime.UtcNow);
        
        userModel.Property(b => b.Created)
            .ValueGeneratedOnAdd()
            .HasDefaultValue(DateTime.UtcNow);
    }
}