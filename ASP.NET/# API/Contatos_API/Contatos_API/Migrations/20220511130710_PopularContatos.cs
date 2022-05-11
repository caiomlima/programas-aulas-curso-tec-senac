using Microsoft.EntityFrameworkCore.Migrations;

namespace Contatos_API.Migrations
{
    public partial class PopularContatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Contatos (Nome, Email, Telefone) VALUES ('User1', 'user1@email.com', '11-91234-5678')");
            migrationBuilder.Sql("INSERT INTO Contatos (Nome, Email, Telefone) VALUES ('User2', 'user1@email.com', '11-91234-7458')");
            migrationBuilder.Sql("INSERT INTO Contatos (Nome, Email, Telefone) VALUES ('User3', 'user1@email.com', '11-91584-5678')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM contatos");
        }
    }
}
