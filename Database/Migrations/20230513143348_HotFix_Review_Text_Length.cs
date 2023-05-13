using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class HotFixReviewTextLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(5441),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(5727),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(9160),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(9418),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(7578),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(7824),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.AlterColumn<string>(
                name: "text",
                table: "reviews",
                type: "character varying(1024)",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "reviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(1446),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "reviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(1784),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(6917),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(7394),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(7740),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(3887),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(4216),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(2829));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(3810),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(4192),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(7906),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(8180),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(6269),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(6540),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.AlterColumn<string>(
                name: "text",
                table: "reviews",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "reviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(192),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "reviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(544),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(5190),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(5519),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 146, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(6282),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(2479),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(2829),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 14, 33, 48, 147, DateTimeKind.Utc).AddTicks(4216));
        }
    }
}
