using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Alunos.Migrations
{
    public partial class AlterandoModelAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FichaRegistro",
                table: "Aluno",
                newName: "DataRegistro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataRegistro",
                table: "Aluno",
                newName: "FichaRegistro");
        }
    }
}
