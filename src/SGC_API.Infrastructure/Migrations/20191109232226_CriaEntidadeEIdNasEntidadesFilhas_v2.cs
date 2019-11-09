using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC_API.Infrastructure.Migrations
{
    public partial class CriaEntidadeEIdNasEntidadesFilhas_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_APP_USUARIO_TBL_APP_AppId",
                table: "TBL_APP_USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_APP_USUARIO_TBL_USUARIO_UsuarioId",
                table: "TBL_APP_USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_CLIENTE_USUARIO_TBL_CLIENTE_ClienteId",
                table: "TBL_CLIENTE_USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_CLIENTE_USUARIO_TBL_USUARIO_UsuarioId",
                table: "TBL_CLIENTE_USUARIO");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_CLIENTE_USUARIO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "TBL_CLIENTE_USUARIO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_APP_USUARIO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppId",
                table: "TBL_APP_USUARIO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_APP_USUARIO_TBL_APP_AppId",
                table: "TBL_APP_USUARIO",
                column: "AppId",
                principalTable: "TBL_APP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_APP_USUARIO_TBL_USUARIO_UsuarioId",
                table: "TBL_APP_USUARIO",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_CLIENTE_USUARIO_TBL_CLIENTE_ClienteId",
                table: "TBL_CLIENTE_USUARIO",
                column: "ClienteId",
                principalTable: "TBL_CLIENTE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_CLIENTE_USUARIO_TBL_USUARIO_UsuarioId",
                table: "TBL_CLIENTE_USUARIO",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_APP_USUARIO_TBL_APP_AppId",
                table: "TBL_APP_USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_APP_USUARIO_TBL_USUARIO_UsuarioId",
                table: "TBL_APP_USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_CLIENTE_USUARIO_TBL_CLIENTE_ClienteId",
                table: "TBL_CLIENTE_USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_CLIENTE_USUARIO_TBL_USUARIO_UsuarioId",
                table: "TBL_CLIENTE_USUARIO");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_CLIENTE_USUARIO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "TBL_CLIENTE_USUARIO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TBL_APP_USUARIO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AppId",
                table: "TBL_APP_USUARIO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_APP_USUARIO_TBL_APP_AppId",
                table: "TBL_APP_USUARIO",
                column: "AppId",
                principalTable: "TBL_APP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_APP_USUARIO_TBL_USUARIO_UsuarioId",
                table: "TBL_APP_USUARIO",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_CLIENTE_USUARIO_TBL_CLIENTE_ClienteId",
                table: "TBL_CLIENTE_USUARIO",
                column: "ClienteId",
                principalTable: "TBL_CLIENTE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_CLIENTE_USUARIO_TBL_USUARIO_UsuarioId",
                table: "TBL_CLIENTE_USUARIO",
                column: "UsuarioId",
                principalTable: "TBL_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
