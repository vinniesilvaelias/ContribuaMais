using ContribuaMais.API.Models.Dados.Infraestrutura;
using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class Doador : EntidadeBase, IEntidadeBase
    {
        public Pessoa Pessoa { get; set; }
    }
}
