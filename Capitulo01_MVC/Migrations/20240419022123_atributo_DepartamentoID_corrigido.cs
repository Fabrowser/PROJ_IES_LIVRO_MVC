using Microsoft.EntityFrameworkCore.Migrations;

namespace Capitulo01_MVC.Migrations
{
    public partial class atributo_DepartamentoID_corrigido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartamentoId",
                table: "Departamentos",
                newName: "DepartamentoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartamentoID",
                table: "Departamentos",
                newName: "DepartamentoId");
        }
    }
}
