using ContribuaMais.API.Models.Dados.Infraestrutura;
using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class ProjetoSocial : EntidadeBase, IEntidadeBase
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public Pessoa PessoaResponsavel { get; set; }
        public IList<Campanha> Campanhas { get; set; }
    }
}
