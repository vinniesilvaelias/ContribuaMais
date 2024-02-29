using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioItem : RepositorioBase<Item>
    {
        public RepositorioItem(ContribuaMaisContexto contexto) : base(contexto)
        {
        }
    }
}
