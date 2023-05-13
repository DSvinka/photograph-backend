using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "users",
                newName: "first_name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(2778),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(3056),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "users",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "second_name",
                table: "users",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(6346),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(4823),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(5133),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(3927),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(4177),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(3952),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 422, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(4324),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 422, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(490),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(859),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    text = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    userid = table.Column<long>(name: "user_id", type: "bigint", nullable: false),
                    lastupdated = table.Column<DateTime>(name: "last_updated", type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(8328)),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(8707))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_reviews", x => x.id);
                    table.ForeignKey(
                        name: "fk_reviews_users_user_id",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_reviews_user_id",
                table: "reviews",
                column: "user_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropColumn(
                name: "email",
                table: "users");

            migrationBuilder.DropColumn(
                name: "second_name",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "users",
                newName: "username");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(2841),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(3090),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "strings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(6048),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4550),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "settings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4751),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(3823),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(4028),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 877, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 422, DateTimeKind.Utc).AddTicks(761),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums_files",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 422, DateTimeKind.Utc).AddTicks(1046),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_updated",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(7413),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "albums",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 10, 21, 47, 58, 421, DateTimeKind.Utc).AddTicks(7722),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 12, 19, 43, 53, 878, DateTimeKind.Utc).AddTicks(859));
        }
    }
}
