using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;
using Domain.Shared.Enums;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public class FileModel: BaseModelWithId
{
    public byte[] FileBytes { get; set; }
    
    [MaxLength(32)] public string Filename { get; set; }
    public EFileType FileType { get; set; }
    
    public int Height { get; set; }
    public int Width { get; set; }

    public static void InitializeEntity(ModelBuilder modelBuilder)
    {
        var userModel = modelBuilder.Entity<FileModel>();
        userModel.ToTable("files");
        userModel.HasKey(b => b.Id);
        
        userModel.Property(b => b.Id)
            .IsRequired();

        userModel.Property(b => b.FileBytes)
            .IsRequired();
        
        userModel.Property(b => b.Filename)
            .HasMaxLength(32)
            .IsRequired();
        
        userModel.Property(b => b.FileType)
            .IsRequired()
            .HasConversion<int>();
        
        userModel.Property(b => b.Height)
            .IsRequired();
        userModel.Property(b => b.Width)
            .IsRequired();

        userModel.Property(b => b.LastUpdated)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValue(DateTime.UtcNow);
        
        userModel.Property(b => b.Created)
            .ValueGeneratedOnAdd()
            .HasDefaultValue(DateTime.UtcNow);
    }
}