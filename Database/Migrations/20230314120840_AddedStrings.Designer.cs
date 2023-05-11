﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230314120840_AddedStrings")]
    partial class AddedStrings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 741, DateTimeKind.Utc).AddTicks(165))
                        .HasColumnName("created");

                    b.Property<long>("FileId")
                        .HasColumnType("bigint")
                        .HasColumnName("file_id");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(9793))
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
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6562))
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2024)
                        .HasColumnType("character varying(2024)")
                        .HasColumnName("description");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6207))
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
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2419))
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

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2145))
                        .HasColumnName("last_updated");

                    b.HasKey("Id")
                        .HasName("pk_files");

                    b.ToTable("files", (string)null);
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
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3388))
                        .HasColumnName("created");

                    b.Property<string>("FrontendUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("frontend_url");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3162))
                        .HasColumnName("last_updated");

                    b.Property<string>("SiteDescription")
                        .IsRequired()
                        .HasMaxLength(2024)
                        .HasColumnType("character varying(2024)")
                        .HasColumnName("site_description");

                    b.Property<string>("SiteSubTitle")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("site_sub_title");

                    b.Property<string>("SiteTitle")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnName("site_title");

                    b.HasKey("Id")
                        .HasName("pk_settings");

                    b.ToTable("settings", (string)null);
                });

            modelBuilder.Entity("Domain.Models.StringModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(4667))
                        .HasColumnName("created");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnName("key");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(4430))
                        .HasColumnName("last_updated");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(4096)
                        .HasColumnType("character varying(4096)")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_strings");

                    b.HasAlternateKey("Key")
                        .HasName("ak_strings_key");

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
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1400))
                        .HasColumnName("created");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1061))
                        .HasColumnName("last_updated");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text")
                        .HasColumnName("refresh_token");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_guild_settings_logs_model");

                    b.ToTable("guild_settings_logs_model", (string)null);
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

            modelBuilder.Entity("Domain.Models.Albums.AlbumModel", b =>
                {
                    b.Navigation("Files");
                });
#pragma warning restore 612, 618
        }
    }
}