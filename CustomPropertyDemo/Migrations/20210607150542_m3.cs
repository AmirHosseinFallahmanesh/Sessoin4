using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomPropertyDemo.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Writer",
                schema: "dbo",
                columns: table => new
                {
                    WriterId = table.Column<Guid>(nullable: false),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writer", x => x.WriterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Writer",
                schema: "dbo");
        }
    }
}
