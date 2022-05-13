using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_NetCore5.Migrations
{
    public partial class CorrecaoLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Livros",
                table: "Livros");

            migrationBuilder.RenameTable(
                name: "Livros",
                newName: "livros");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "livros",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_livros",
                table: "livros",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_livros",
                table: "livros");

            migrationBuilder.RenameTable(
                name: "livros",
                newName: "Livros");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Livros",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livros",
                table: "Livros",
                column: "Id");
        }
    }
}
