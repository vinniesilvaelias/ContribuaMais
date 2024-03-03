using ContribuaMais.API.Models.Dados.Infraestrutura;

namespace ContribuaMais.API.Dados.Repositorios.Infraestrutura
{
    public class RepositorioDocumentosPessoais : RepositorioBase<DocumentosPessoais>
    {
        public RepositorioDocumentosPessoais(ContribuaMaisContexto contexto) : base(contexto)
        {
        }
    }
}
