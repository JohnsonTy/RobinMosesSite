using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RobinMoses.Migrations
{
    public partial class coolguy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "BlogPosts",
                type: "longblob",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "BlogPosts");
        }
    }
}
