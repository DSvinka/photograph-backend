﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Albums.AlbumFileRelation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AlbumId")
                        .HasColumnType("bigint")
                        .HasColumnName("album_id");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(7740))
                        .HasColumnName("created");

                    b.Property<long>("FileId")
                        .HasColumnType("bigint")
                        .HasColumnName("file_id");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(7394))
                        .HasColumnName("last_updated");

                    b.HasKey("Id")
                        .HasName("pk_albums_files");

                    b.HasIndex("AlbumId")
                        .HasDatabaseName("ix_albums_files_album_id");

                    b.HasIndex("FileId")
                        .HasDatabaseName("ix_albums_files_file_id");

                    b.ToTable("albums_files", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Albums.AlbumModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ButtonName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("button_name");

                    b.Property<long>("CoverFileId")
                        .HasColumnType("bigint")
                        .HasColumnName("cover_file_id");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(4216))
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2024)
                        .HasColumnType("character varying(2024)")
                        .HasColumnName("description");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(3887))
                        .HasColumnName("last_updated");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_albums");

                    b.HasIndex("CoverFileId")
                        .HasDatabaseName("ix_albums_cover_file_id");

                    b.ToTable("albums", (string)null);
                });

            modelBuilder.Entity("Domain.Models.FileModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(6917))
                        .HasColumnName("created");

                    b.Property<byte[]>("FileBytes")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("file_bytes");

                    b.Property<int>("FileType")
                        .HasColumnType("integer")
                        .HasColumnName("file_type");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnName("filename");

                    b.Property<int>("Height")
                        .HasColumnType("integer")
                        .HasColumnName("height");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(6668))
                        .HasColumnName("last_updated");

                    b.Property<int>("Width")
                        .HasColumnType("integer")
                        .HasColumnName("width");

                    b.HasKey("Id")
                        .HasName("pk_files");

                    b.ToTable("files", (string)null);
                });

            modelBuilder.Entity("Domain.Models.ReviewModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(1784))
                        .HasColumnName("created");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(1446))
                        .HasColumnName("last_updated");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)")
                        .HasColumnName("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_reviews");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasDatabaseName("ix_reviews_user_id");

                    b.ToTable("reviews", (string)null);
                });

            modelBuilder.Entity("Domain.Models.SettingsModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("BackendUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("backend_url");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(7824))
                        .HasColumnName("created");

                    b.Property<string>("FrontendUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("frontend_url");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(7578))
                        .HasColumnName("last_updated");

                    b.HasKey("Id")
                        .HasName("pk_settings");

                    b.ToTable("settings", (string)null);
                });

            modelBuilder.Entity("Domain.Models.StringModel", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnName("key");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(9418))
                        .HasColumnName("created");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(9160))
                        .HasColumnName("last_updated");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(4096)
                        .HasColumnType("character varying(4096)")
                        .HasColumnName("value");

                    b.HasKey("Key")
                        .HasName("pk_strings");

                    b.ToTable("strings", (string)null);
                });

            modelBuilder.Entity("Domain.Models.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Administrator")
                        .HasColumnType("boolean")
                        .HasColumnName("administrator");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(5727))
                        .HasColumnName("created");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<string>("FamilyName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("family_name");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("first_name");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(5441))
                        .HasColumnName("last_updated");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text")
                        .HasColumnName("refresh_token");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Albums.AlbumFileRelation", b =>
                {
                    b.HasOne("Domain.Models.Albums.AlbumModel", "Album")
                        .WithMany("Files")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_albums_files_albums_album_id");

                    b.HasOne("Domain.Models.FileModel", "File")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_albums_files_files_file_id");

                    b.Navigation("Album");

                    b.Navigation("File");
                });

            modelBuilder.Entity("Domain.Models.Albums.AlbumModel", b =>
                {
                    b.HasOne("Domain.Models.FileModel", "CoverFile")
                        .WithMany()
                        .HasForeignKey("CoverFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_albums_files_cover_file_id");

                    b.Navigation("CoverFile");
                });

            modelBuilder.Entity("Domain.Models.ReviewModel", b =>
                {
                    b.HasOne("Domain.Models.UserModel", "User")
                        .WithOne("Review")
                        .HasForeignKey("Domain.Models.ReviewModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reviews_users_user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Albums.AlbumModel", b =>
                {
                    b.Navigation("Files");
                });

            modelBuilder.Entity("Domain.Models.UserModel", b =>
                {
                    b.Navigation("Review");
                });
#pragma warning restore 612, 618
        }
    }
}
