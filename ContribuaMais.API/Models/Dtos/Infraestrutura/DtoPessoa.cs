using ContribuaMais.API.Models.Dados.Infraestrutura.Enumeradores;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Models.Dtos.Infraestrutura;
using ContribuaMais.API.Models.Interfaces;

namespace ContribuaMais.API.Models.Dados.Dtos.Infraestrutura
{
    public class DtoPessoa : DtoBase, IDto
    {
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public EnumSexo? Sexo { get; set; }
        public DtoEndereco? Endereco { get; set; }
        public DtoDocumentosPessoais? DocumentosPessoais { get; set; }
        public DtoContato? Contato { get; set; }
    }
}
