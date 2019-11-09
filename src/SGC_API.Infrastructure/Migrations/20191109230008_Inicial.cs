using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC_API.Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_APP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCadastro = table.Column<int>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_APP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_CLIENTE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCadastro = table.Column<int>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    CpfCnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CLIENTE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TERCEIRO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCadastro = table.Column<int>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TERCEIRO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_USUARIO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCadastro = table.Column<int>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: true),
                    NomeCompleto = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    Documento = table.Column<string>(nullable: true),
                    TipoDocumento = table.Column<string>(nullable: true),
                    Filiacao = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    Administrador = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USUARIO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_APP_USUARIO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCadastro = table.Column<int>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: true),
                    AppId = table.Column<int>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_APP_USUARIO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_APP_USUARIO_TBL_APP_AppId",
                        column: x => x.AppId,
                        principalTable: "TBL_APP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_APP_USUARIO_TBL_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TBL_USUARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_CLIENTE_USUARIO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCadastro = table.Column<int>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CLIENTE_USUARIO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_CLIENTE_USUARIO_TBL_CLIENTE_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TBL_CLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_CLIENTE_USUARIO_TBL_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TBL_USUARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_USUARIO_CONTATO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCadastro = table.Column<int>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: true),
                    Ddi = table.Column<string>(nullable: true),
                    Ddd = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USUARIO_CONTATO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_USUARIO_CONTATO_TBL_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TBL_USUARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_USUARIO_EMAIL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCadastro = table.Column<int>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USUARIO_EMAIL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_USUARIO_EMAIL_TBL_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TBL_USUARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_USUARIO_ENDERECO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCadastro = table.Column<int>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USUARIO_ENDERECO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_USUARIO_ENDERECO_TBL_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TBL_USUARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_APP_USUARIO_AppId",
                table: "TBL_APP_USUARIO",
                column: "AppId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_APP_USUARIO_UsuarioId",
                table: "TBL_APP_USUARIO",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_CLIENTE_USUARIO_ClienteId",
                table: "TBL_CLIENTE_USUARIO",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_CLIENTE_USUARIO_UsuarioId",
                table: "TBL_CLIENTE_USUARIO",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_USUARIO_CONTATO_UsuarioId",
                table: "TBL_USUARIO_CONTATO",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_USUARIO_EMAIL_UsuarioId",
                table: "TBL_USUARIO_EMAIL",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_USUARIO_ENDERECO_UsuarioId",
                table: "TBL_USUARIO_ENDERECO",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_APP_USUARIO");

            migrationBuilder.DropTable(
                name: "TBL_CLIENTE_USUARIO");

            migrationBuilder.DropTable(
                name: "TBL_TERCEIRO");

            migrationBuilder.DropTable(
                name: "TBL_USUARIO_CONTATO");

            migrationBuilder.DropTable(
                name: "TBL_USUARIO_EMAIL");

            migrationBuilder.DropTable(
                name: "TBL_USUARIO_ENDERECO");

            migrationBuilder.DropTable(
                name: "TBL_APP");

            migrationBuilder.DropTable(
                name: "TBL_CLIENTE");

            migrationBuilder.DropTable(
                name: "TBL_USUARIO");
        }
    }
}
