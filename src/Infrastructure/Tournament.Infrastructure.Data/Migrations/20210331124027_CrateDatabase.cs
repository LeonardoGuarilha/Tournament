using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tournament.Infrastructure.Data.Migrations
{
    public partial class CrateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameEnd",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameStart",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GuestScore",
                table: "Games");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndGameHour",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartGameHour",
                table: "Games",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VisitoursScore",
                table: "Games",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndGameHour",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "StartGameHour",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "VisitoursScore",
                table: "Games");

            migrationBuilder.AddColumn<DateTime>(
                name: "GameEnd",
                table: "Games",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GameStart",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GuestScore",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
