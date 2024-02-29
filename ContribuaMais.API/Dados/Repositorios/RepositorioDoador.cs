using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioDoador : RepositorioBase<Doador>
    {
        public RepositorioDoador(ContribuaMaisContexto contexto) : base(contexto)
        {
        }
    }
}
