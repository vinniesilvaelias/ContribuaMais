using ContribuaMais.API.Models.Dados.Infraestrutura;

namespace ContribuaMais.API.Dados.Repositorios.Infraestrutura
{
    public class RepositorioPessoa : RepositorioBase<Pessoa>
    {
        public RepositorioPessoa(ContribuaMaisContexto contexto) : base(contexto)
        {
        }
    }
}
