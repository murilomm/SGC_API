using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC_API.Infrastructure.Migrations
{
    public partial class CriaEntidadeEIdNasEntidadesFilhas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USUARIO_CONTATO_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_CONTATO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USUARIO_EMAIL_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_EMAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USUARIO_ENDERECO_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_ENDERECO");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_USUARIO_ENDERECO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_USUARIO_EMAIL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_USUARIO_CONTATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USUARIO_CONTATO_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_CONTATO",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USUARIO_EMAIL_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_EMAIL",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USUARIO_ENDERECO_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_ENDERECO",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USUARIO_CONTATO_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_CONTATO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USUARIO_EMAIL_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_EMAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_USUARIO_ENDERECO_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_ENDERECO");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_USUARIO_ENDERECO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_USUARIO_EMAIL",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_USUARIO_CONTATO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USUARIO_CONTATO_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_CONTATO",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USUARIO_EMAIL_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_EMAIL",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_USUARIO_ENDERECO_TBL_USUARIO_UsuarioId",
                table: "TBL_USUARIO_ENDERECO",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
