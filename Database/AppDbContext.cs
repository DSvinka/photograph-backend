using Domain.Models;
using Domain.Models.Albums;
using Microsoft.EntityFrameworkCore;

namespace Database;

public class AppDbContext: DbContext
{
    public DbSet<SettingsModel> Settings { get; set; } = null!;
    public DbSet<UserModel> Users { get; set; } = null!;
    public DbSet<FileModel> Files { get; set; } = null!;
    public DbSet<ReviewModel> Reviews { get; set; } = null!;

    public DbSet<StringModel> Strings { get; set; } = null!;
    
    public DbSet<AlbumModel> Albums { get; set; } = null!;
    public DbSet<AlbumFileRelation> AlbumFiles { get; set; } = null!;
    
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {

    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Применяем snake_case правило наименования полей и таблиц.
        optionsBuilder.UseSnakeCaseNamingConvention();
    }
    
    // Данный метод инициализирует модели базы данных.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        UserModel.InitializeEntity(modelBuilder);
        FileModel.InitializeEntity(modelBuilder);
        SettingsModel.InitializeEntity(modelBuilder);
        StringModel.InitializeEntity(modelBuilder);
        ReviewModel.InitializeEntity(modelBuilder);
        
        AlbumModel.InitializeEntity(modelBuilder);
        AlbumFileRelation.InitializeEntity(modelBuilder);
    }
}