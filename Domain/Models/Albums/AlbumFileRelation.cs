using Domain.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models.Albums;

public class AlbumFileRelation: BaseModelWithId
{
    public long AlbumId { get; set; }
    public AlbumModel Album { get; set; }
    
    public long FileId { get; set; }
    public FileModel File { get; set; }

    public static void InitializeEntity(ModelBuilder modelBuilder)
    {
        var userModel = modelBuilder.Entity<AlbumFileRelation>();
        userModel.ToTable("albums_files");
        userModel.HasKey(b => b.Id);
        
        userModel.Property(b => b.Id)
            .IsRequired();

        userModel.HasOne(b => b.Album)
            .WithMany(b => b.Files)
            .HasForeignKey(p => p.AlbumId);
        
        userModel.HasOne(b => b.File)
            .WithMany()
            .HasForeignKey(p => p.FileId);

        userModel.Property(b => b.LastUpdated)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValue(DateTime.UtcNow);
        
        userModel.Property(b => b.Created)
            .ValueGeneratedOnAdd()
            .HasDefaultValue(DateTime.UtcNow);
    }
}