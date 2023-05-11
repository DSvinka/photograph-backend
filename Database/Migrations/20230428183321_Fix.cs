using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "ak_strings_key",
                table: "strings");

            migrationBuilder.DropPrimaryKey(
                name: "pk_strings",
                table: "strings");

            migrationBuilder.DropPrimaryKey(
                name: "pk_guild_settings_logs_model",
                table: "guild_settings_logs_model");

            migrationBuilder.DropColumn(
                name: "id",
                table: "strings");

            migrationBuilder.DropColumn(
                name: "site_description",
                table: "settings");

            migrationBuilder.DropColumn(
                name: "site_sub_title",
                table: "settings");

            migrationBuilder.DropColumn(
                name: "site_title",
                table: "settings");

            migrationBuilder.RenameTable(
                name: "guild_settings_logs_model",
                newName: "users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(1063),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(9345),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(9585),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(8439),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(8726),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(6473),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(6861),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 741, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(2734),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(3051),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(7275),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(7602),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.AddPrimaryKey(
                name: "pk_strings",
                table: "strings",
                column: "key");

            migrationBuilder.AddPrimaryKey(
                name: "pk_users",
                table: "users",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_strings",
                table: "strings");

            migrationBuilder.DropPrimaryKey(
                name: "pk_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "guild_settings_logs_model");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(4430),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(4667),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.AddColumn<long>(
                name: "id",
                table: "strings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3162),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(3388),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.AddColumn<string>(
                name: "site_description",
                table: "settings",
                type: "character varying(2024)",
                maxLength: 2024,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "site_sub_title",
                table: "settings",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "site_title",
                table: "settings",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2145),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(9793),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 741, DateTimeKind.Utc).AddTicks(165),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6207),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1061),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 12, 8, 40, 740, DateTimeKind.Utc).AddTicks(1400),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.AddUniqueConstraint(
                name: "ak_strings_key",
                table: "strings",
                column: "key");

            migrationBuilder.AddPrimaryKey(
                name: "pk_strings",
                table: "strings",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_guild_settings_logs_model",
                table: "guild_settings_logs_model",
                column: "id");
        }
    }
}
