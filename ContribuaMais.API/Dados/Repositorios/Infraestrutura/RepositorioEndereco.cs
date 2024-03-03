using ContribuaMais.API.Models.Dados.Infraestrutura;

namespace ContribuaMais.API.Dados.Repositorios.Infraestrutura
{
    public class RepositorioEndereco : RepositorioBase<Endereco>
    {
        public RepositorioEndereco(ContribuaMaisContexto contexto) : base(contexto)
        {
        }
    }
}
