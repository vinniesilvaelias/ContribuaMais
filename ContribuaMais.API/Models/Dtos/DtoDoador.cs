using ContribuaMais.API.Models.Dados.Dtos.Infraestrutura;
using ContribuaMais.API.Models.Interfaces;

namespace ContribuaMais.API.Models.Dtos
{
    public class DtoDoador : DtoBase, IDto
    {
        public DtoPessoa Pessoa { get; set; }
    }
}
