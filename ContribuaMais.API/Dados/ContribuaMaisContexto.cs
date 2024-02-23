using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;
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

    }
}
