using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dados.Infraestrutura;
using Microsoft.EntityFrameworkCore;

namespace ContribuaMais.API.Dados
{
    public class ContribuaMaisContexto : DbContext
    {
        public ContribuaMaisContexto(DbContextOptions<ContribuaMaisContexto> opcoes)
            : base(opcoes)
        {
        }

        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<ProjetoSocial> ProjetoSociais { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<DocumentosPessoais> DocumentosPessoais { get; set; }
    }
}
