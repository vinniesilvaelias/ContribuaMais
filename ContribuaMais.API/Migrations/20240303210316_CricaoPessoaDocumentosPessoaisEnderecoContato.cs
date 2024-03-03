using ContribuaMais.API.Models.Dados.Infraestrutura.Enumeradores;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContribuaMais.API.Migrations
{
    /// <inheritdoc />
    public partial class CricaoPessoaDocumentosPessoaisEnderecoContato : Migration
    {

        // <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Cpf",
            //    table: "Doadores");

            //migrationBuilder.DropColumn(
            //    name: "Endereco",
            //    table: "Doadores");

            //migrationBuilder.DropColumn(
            //    name: "Nome",
            //    table: "Doadores");

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SobreNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sexo = table.Column<EnumSexo>(type: "int", nullable: true),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentosPessoaisId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            //migrationBuilder.AddColumn<Guid>(
            //    name: "PessoaId",
            //    table: "Doadores",
            //    type: "uniqueidentifier",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Doadores_PessoaId",
            //    table: "Doadores",
            //    column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doadores_Pessoas_PessoaId",
                table: "Doadores",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id");

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instragram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosPessoais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosPessoais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<int>(type: "int", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_ContatoId",
                table: "Pessoas",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_DocumentosPessoaisId",
                table: "Pessoas",
                column: "DocumentosPessoaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Contatos_ContatoId",
                table: "Pessoas",
                column: "ContatoId",
                principalTable: "Contatos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_DocumentosPessoais_DocumentosPessoaisId",
                table: "Pessoas",
                column: "DocumentosPessoaisId",
                principalTable: "DocumentosPessoais",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecosId",
                table: "Pessoas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id");
        }

        // <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_Doadores_Pessoas_PessoaId",
                table: "Doadores");

            migrationBuilder.DropIndex(
                name: "IX_Doadores_PessoaId",
                table: "Doadores");

            //////////////////////////////////////////////////////////////////

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Contatos_ContatoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_DocumentosPessoais_DocumentosPessoaisId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoId",
                table: "Pessoas");


            migrationBuilder.DropForeignKey(
                name: "FK_Doadores_Pessoas_PessoasId",
                table: "Doadores");

            migrationBuilder.DropIndex(
                name: "IX_Doadores_PessoasId",
                table: "Doadores");

            migrationBuilder.DropColumn(
                name: "PessoasId",
                table: "Doadores");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "DocumentosPessoais");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_ContatoId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_DocumentosPessoaisId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_EnderecosId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "ContatoId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DocumentosPessoaisId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "EnderecosId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "SobreNome",
                table: "Pessoas");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Doadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Doadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Enderecos",
                table: "Doadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
