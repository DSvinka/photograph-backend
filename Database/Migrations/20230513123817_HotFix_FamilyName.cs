using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class HotFixFamilyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "second_name",
                table: "users",
                newName: "family_name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(3810),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(4192),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(7906),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(8180),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(6269),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(6540),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "reviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(192),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "reviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(544),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(5190),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(5519),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(6282),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(2479),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(2829),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(859));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "family_name",
                table: "users",
                newName: "second_name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(2778),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(3056),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(6346),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(4823),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(5133),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "reviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(8328),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "reviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(8707),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(3927),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(4177),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 760, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(3952),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(4324),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(490),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(859),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 13, 12, 38, 17, 761, DateTimeKind.Utc).AddTicks(2829));
        }
    }
}
