using ContribuaMais.API.Models.Dados.Infraestrutura.Enumeradores;
using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados.Infraestrutura
{
    public class Pessoa : EntidadeBase, IEntidadeBase
    {
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public EnumSexo? Sexo { get; set; }
        public Endereco? Endereco { get; set; }
        public DocumentosPessoais? DocumentosPessoais { get; set; }
        public Contato? Contato { get; set; }
    }
}
