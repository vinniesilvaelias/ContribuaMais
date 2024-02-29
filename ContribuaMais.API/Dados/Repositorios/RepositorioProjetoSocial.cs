using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioProjetoSocial : RepositorioBase<ProjetoSocial>
    {
        public RepositorioProjetoSocial(ContribuaMaisContexto contexto) : base(contexto)
        {
        }
    }
}
