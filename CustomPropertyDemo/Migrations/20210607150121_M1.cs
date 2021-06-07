using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomPropertyDemo.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Books",
                newName: "AuthorAutorCode");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                newName: "IX_Books_AuthorAutorCode");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Authors",
                newName: "AutorCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorAutorCode",
                table: "Books",
                column: "AuthorAutorCode",
                principalTable: "Authors",
                principalColumn: "AutorCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorAutorCode",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "AuthorAutorCode",
                table: "Books",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorAutorCode",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.RenameColumn(
                name: "AutorCode",
                table: "Authors",
                newName: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
