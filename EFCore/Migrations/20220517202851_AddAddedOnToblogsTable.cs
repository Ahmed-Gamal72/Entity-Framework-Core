using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class AddAddedOnToblogsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Bloging");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Posts",
                newSchema: "Bloging");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "blogs");

            migrationBuilder.RenameTable(
                name: "Posts",
                schema: "Bloging",
                newName: "Posts");
        }
    }
}
