using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "files",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    filename = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    filefolder = table.Column<int>(name: "file_folder", type: "integer", nullable: false),
                    filetype = table.Column<int>(name: "file_type", type: "integer", nullable: false),
                    lastupdated = table.Column<DateTime>(name: "last_updated", type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(3865)),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(4113))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_files", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "guild_settings_logs_model",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false, defaultValue: "0"),
                    passwordhash = table.Column<string>(name: "password_hash", type: "text", nullable: false, defaultValue: "0"),
                    administrator = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    refreshtoken = table.Column<string>(name: "refresh_token", type: "text", nullable: false, defaultValue: "0"),
                    lastupdated = table.Column<DateTime>(name: "last_updated", type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(2831)),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(3090))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_guild_settings_logs_model", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "settings",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sitetitle = table.Column<string>(name: "site_title", type: "character varying(32)", maxLength: 32, nullable: false),
                    sitedescription = table.Column<string>(name: "site_description", type: "character varying(256)", maxLength: 256, nullable: false),
                    lastupdated = table.Column<DateTime>(name: "last_updated", type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(4780)),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(5022))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_settings", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "files");

            migrationBuilder.DropTable(
                name: "guild_settings_logs_model");

            migrationBuilder.DropTable(
                name: "settings");
        }
    }
}
