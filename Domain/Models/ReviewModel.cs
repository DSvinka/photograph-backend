using System.ComponentModel.DataAnnotations;
using Domain.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public class ReviewModel: BaseModelWithId
{
    public string Text { get; set; }
    
    public long UserId { get; set; }
    public UserModel User { get; set; }
    
    public static void InitializeEntity(ModelBuilder modelBuilder)
    {
        var userModel = modelBuilder.Entity<ReviewModel>();
        userModel.ToTable("reviews");
        userModel.HasKey(b => b.Id);

        userModel.Property(b => b.Id)
            .IsRequired();
        
        userModel.Property(b => b.Text)
            .IsRequired()
            .HasMaxLength(1024);
        
        userModel.HasOne(b => b.User)
            .WithOne(x => x.Review)
            .HasForeignKey<ReviewModel>(x => x.UserId);
        
        userModel.Property(b => b.LastUpdated)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValue(DateTime.UtcNow);

        userModel.Property(b => b.Created)
            .ValueGeneratedOnAdd()
            .HasDefaultValue(DateTime.UtcNow);
    }
}