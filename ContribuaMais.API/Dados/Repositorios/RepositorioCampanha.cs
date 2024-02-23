using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioCampanha : RepositorioGenerico<Campanha>
    {
        public RepositorioCampanha(ContribuaMaisContexto contexto) : base(contexto)
        {
        }
    }
}
