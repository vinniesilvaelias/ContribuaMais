using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioCampanha : RepositorioBase<Campanha>
    {
        public RepositorioCampanha(ContribuaMaisContexto contexto) : base(contexto)
        {
        }
    }
}
