using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_EF_CORE.Migrations
{
    public partial class EntidadeTipoSocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoSocioId",
                table: "Alunos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipoSocios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DuracaoEmMeses = table.Column<int>(type: "int", nullable: false),
                    taxaDesconto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSocios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TipoSocioId",
                table: "Alunos",
                column: "TipoSocioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoSocios_TipoSocioId",
                table: "Alunos",
                column: "TipoSocioId",
                principalTable: "TipoSocios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoSocios_TipoSocioId",
                table: "Alunos");

            migrationBuilder.DropTable(
                name: "TipoSocios");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TipoSocioId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "TipoSocioId",
                table: "Alunos");
        }
    }
}
