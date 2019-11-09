using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC_API.Infrastructure.Migrations
{
    public partial class CriaSobrenomeTabelaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeCompleto",
                table: "TBL_USUARIO");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "TBL_USUARIO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "TBL_USUARIO",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "TBL_USUARIO");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "TBL_USUARIO");

            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "TBL_USUARIO",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
