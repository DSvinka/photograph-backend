using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedWidthAndHeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(2841),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(3090),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(6048),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4550),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4751),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(3823),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4028),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.AddColumn<int>(
                name: "height",
                table: "files",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "width",
                table: "files",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 422, DateTimeKind.Utc).AddTicks(761),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 422, DateTimeKind.Utc).AddTicks(1046),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(7413),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(7722),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(3051));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "height",
                table: "files");

            migrationBuilder.DropColumn(
                name: "width",
                table: "files");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(7275),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(7602),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(1063),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(9345),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(9585),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(8439),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 564, DateTimeKind.Utc).AddTicks(8726),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(6473),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 422, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(6861),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 422, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(2734),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 18, 33, 21, 565, DateTimeKind.Utc).AddTicks(3051),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(7722));
        }
    }
}
