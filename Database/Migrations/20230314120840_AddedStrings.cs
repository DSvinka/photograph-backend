using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedStrings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3162),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3388),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1061),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 478, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1400),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 478, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2145),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(9793),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 741, DateTimeKind.Utc).AddTicks(165),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6207),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.CreateTable(
                name: "strings",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    key = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    value = table.Column<string>(type: "character varying(4096)", maxLength: 4096, nullable: false),
                    lastupdated = table.Column<DateTime>(name: "last_updated", type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(4430)),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(4667))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_strings", x => x.id);
                    table.UniqueConstraint("ak_strings_key", x => x.key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "strings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(2667),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(2942),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 478, DateTimeKind.Utc).AddTicks(9147),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 478, DateTimeKind.Utc).AddTicks(9610),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(780),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(1184),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(8958),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(9297),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 741, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(4908),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 23, 9, 4, 479, DateTimeKind.Utc).AddTicks(5237),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6562));
        }
    }
}
