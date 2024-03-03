using ContribuaMais.API.Models.Interfaces;

namespace ContribuaMais.API.Models.Dtos.Infraestrutura
{
    public class DtoDocumentosPessoais : DtoBase, IDto
    {
        public string? CPF { get; set; }
        public string? RG { get; set; }
    }
}
