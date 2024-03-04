using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContribuaMais.API.Migrations
{
    /// <inheritdoc />
    public partial class CriandoRelacionamentoEntrePessoaEProjetoSocial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PessoaResponsavelId",
                table: "ProjetoSociais",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoSociais_PessoaResponsavelId",
                table: "ProjetoSociais",
                column: "PessoaResponsavelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoSociais_Pessoas_PessoaResponsavelId",
                table: "ProjetoSociais",
                column: "PessoaResponsavelId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoSociais_Pessoas_PessoaResponsavelId",
                table: "ProjetoSociais");

            migrationBuilder.DropIndex(
                name: "IX_ProjetoSociais_PessoaResponsavelId",
                table: "ProjetoSociais");

            migrationBuilder.DropColumn(
                name: "PessoaResponsavelId",
                table: "ProjetoSociais");
        }
    }
}
