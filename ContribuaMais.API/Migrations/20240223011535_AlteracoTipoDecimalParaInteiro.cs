using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContribuaMais.API.Migrations
{
    /// <inheritdoc />
    public partial class AlteracoTipoDecimalParaInteiro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjetoSocials",
                table: "ProjetoSocials");

            migrationBuilder.RenameTable(
                name: "ProjetoSocials",
                newName: "ProjetoSociais");

            migrationBuilder.AlterColumn<int>(
                name: "Quantidade",
                table: "Doacoes",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Objetivo",
                table: "Campanhas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Arrecadado",
                table: "Campanhas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjetoSociais",
                table: "ProjetoSociais",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjetoSociais",
                table: "ProjetoSociais");

            migrationBuilder.RenameTable(
                name: "ProjetoSociais",
                newName: "ProjetoSocials");

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantidade",
                table: "Doacoes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Objetivo",
                table: "Campanhas",
                type: "decimal(2,2)",
                precision: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Arrecadado",
                table: "Campanhas",
                type: "decimal(2,2)",
                precision: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjetoSocials",
                table: "ProjetoSocials",
                column: "Id");
        }
    }
}
