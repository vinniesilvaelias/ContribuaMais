using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados.Infraestrutura
{
    public class DocumentosPessoais : EntidadeBase, IEntidadeBase
    {
        public string? CPF { get; set; }
        public string? RG { get; set; }
    }
}
