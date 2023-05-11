using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class AlbumsAndAuthFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "file_folder",
                table: "files");

            migrationBuilder.AlterColumn<string>(
                name: "site_description",
                table: "settings",
                type: "character varying(2024)",
                maxLength: 2024,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(2667),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(2942),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.AddColumn<string>(
                name: "site_sub_title",
                table: "settings",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "guild_settings_logs_model",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "refresh_token",
                table: "guild_settings_logs_model",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "password_hash",
                table: "guild_settings_logs_model",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 478, DateTimeKind.Utc).AddTicks(9147),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 478, DateTimeKind.Utc).AddTicks(9610),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.AlterColumn<bool>(
                name: "administrator",
                table: "guild_settings_logs_model",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(780),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(1184),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.AddColumn<byte[]>(
                name: "file_bytes",
                table: "files",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.CreateTable(
                name: "albums",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    buttonname = table.Column<string>(name: "button_name", type: "character varying(256)", maxLength: 256, nullable: false),
                    title = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    description = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    coverfileid = table.Column<long>(name: "cover_file_id", type: "bigint", nullable: false),
                    lastupdated = table.Column<DateTime>(name: "last_updated", type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(4908)),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(5237))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_albums", x => x.id);
                    table.ForeignKey(
                        name: "fk_albums_files_cover_file_id",
                        column: x => x.coverfileid,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "albums_files",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    albumid = table.Column<long>(name: "album_id", type: "bigint", nullable: false),
                    fileid = table.Column<long>(name: "file_id", type: "bigint", nullable: false),
                    lastupdated = table.Column<DateTime>(name: "last_updated", type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(8958)),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(9297))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_albums_files", x => x.id);
                    table.ForeignKey(
                        name: "fk_albums_files_albums_album_id",
                        column: x => x.albumid,
                        principalTable: "albums",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_albums_files_files_file_id",
                        column: x => x.fileid,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_albums_cover_file_id",
                table: "albums",
                column: "cover_file_id");

            migrationBuilder.CreateIndex(
                name: "ix_albums_files_album_id",
                table: "albums_files",
                column: "album_id");

            migrationBuilder.CreateIndex(
                name: "ix_albums_files_file_id",
                table: "albums_files",
                column: "file_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "albums_files");

            migrationBuilder.DropTable(
                name: "albums");

            migrationBuilder.DropColumn(
                name: "site_sub_title",
                table: "settings");

            migrationBuilder.DropColumn(
                name: "file_bytes",
                table: "files");

            migrationBuilder.AlterColumn<string>(
                name: "site_description",
                table: "settings",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2024)",
                oldMaxLength: 2024);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3956),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(4262),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "guild_settings_logs_model",
                type: "text",
                nullable: false,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "refresh_token",
                table: "guild_settings_logs_model",
                type: "text",
                nullable: false,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password_hash",
                table: "guild_settings_logs_model",
                type: "text",
                nullable: false,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(2195),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 478, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(2416),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 478, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.AlterColumn<bool>(
                name: "administrator",
                table: "guild_settings_logs_model",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3059),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3259),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.AddColumn<int>(
                name: "file_folder",
                table: "files",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
