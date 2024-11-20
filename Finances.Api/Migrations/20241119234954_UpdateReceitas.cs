using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finances.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReceitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Categorias_CategoriaId",
                table: "Receitas");

            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Usuarios_UsuarioId",
                table: "Receitas");

            migrationBuilder.DropIndex(
                name: "IX_Receitas_CategoriaId",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "IdCategoria",
                table: "Receitas");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Receitas",
                newName: "IdUsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Receitas",
                newName: "IdCategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Receitas_UsuarioId",
                table: "Receitas",
                newName: "IX_Receitas_IdUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_IdCategoriaId",
                table: "Receitas",
                column: "IdCategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Categorias_IdCategoriaId",
                table: "Receitas",
                column: "IdCategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Usuarios_IdUsuarioId",
                table: "Receitas",
                column: "IdUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Categorias_IdCategoriaId",
                table: "Receitas");

            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Usuarios_IdUsuarioId",
                table: "Receitas");

            migrationBuilder.DropIndex(
                name: "IX_Receitas_IdCategoriaId",
                table: "Receitas");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioId",
                table: "Receitas",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdCategoriaId",
                table: "Receitas",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Receitas_IdUsuarioId",
                table: "Receitas",
                newName: "IX_Receitas_UsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Receitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "Receitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_CategoriaId",
                table: "Receitas",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Categorias_CategoriaId",
                table: "Receitas",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Usuarios_UsuarioId",
                table: "Receitas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
