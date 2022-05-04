using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_EF_CORE.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO alunos (Nome, Sexo, Email, Nascimento) VALUES ('User1', 'Masculino', 'user1@email.com', '2001-05-01')");
            migrationBuilder.Sql("INSERT INTO alunos (Nome, Sexo, Email, Nascimento) VALUES ('User2', 'Masculino', 'user2@email.com', '2000-03-12')");
            migrationBuilder.Sql("INSERT INTO alunos (Nome, Sexo, Email, Nascimento) VALUES ('User3', 'Feminino', 'user3@email.com', '1997-04-11')");
            migrationBuilder.Sql("INSERT INTO alunos (Nome, Sexo, Email, Nascimento) VALUES ('User4', 'Feminino', 'user4@email.com', '2003-09-01')");
            migrationBuilder.Sql("INSERT INTO alunos (Nome, Sexo, Email, Nascimento) VALUES ('User5', 'Feminino', 'user5@email.com', '2000-01-04')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM alunos");
        }
    }
}
