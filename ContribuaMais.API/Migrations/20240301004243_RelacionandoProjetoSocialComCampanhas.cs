using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContribuaMais.API.Migrations
{
    /// <inheritdoc />
    public partial class RelacionandoProjetoSocialComCampanhas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProjetoSocialId",
                table: "Campanhas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campanhas_ProjetoSocialId",
                table: "Campanhas",
                column: "ProjetoSocialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campanhas_ProjetoSociais_ProjetoSocialId",
                table: "Campanhas",
                column: "ProjetoSocialId",
                principalTable: "ProjetoSociais",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campanhas_ProjetoSociais_ProjetoSocialId",
                table: "Campanhas");

            migrationBuilder.DropIndex(
                name: "IX_Campanhas_ProjetoSocialId",
                table: "Campanhas");

            migrationBuilder.DropColumn(
                name: "ProjetoSocialId",
                table: "Campanhas");
        }
    }
}
