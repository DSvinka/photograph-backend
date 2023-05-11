using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class SettingsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3956),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(4262),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.AddColumn<string>(
                name: "backend_url",
                table: "settings",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "frontend_url",
                table: "settings",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(2195),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(2416),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3059),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3259),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(4113));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "backend_url",
                table: "settings");

            migrationBuilder.DropColumn(
                name: "frontend_url",
                table: "settings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(5022),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(2831),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "guild_settings_logs_model",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(3090),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(3865),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 30, 21, 6, 21, 365, DateTimeKind.Utc).AddTicks(4113),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 1, 31, 13, 24, 27, 348, DateTimeKind.Utc).AddTicks(3259));
        }
    }
}
