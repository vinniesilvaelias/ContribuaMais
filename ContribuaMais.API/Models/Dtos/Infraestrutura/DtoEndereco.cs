using ContribuaMais.API.Models.Dados.Infraestrutura.Enumeradores;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Models.Interfaces;

namespace ContribuaMais.API.Models.Dados.Dtos.Infraestrutura
{
    public class DtoEndereco : DtoBase, IDto
    {
        public EnumTipoLogradouro? Logradouro { get; set; }
        public string? Numero { get; set; } 
        public string? Complemento { get; set; } 
        public string? Bairro { get; set; } 
        public string? Cidade { get; set; } 
        public string? Estado { get; set; } 
        public string CEP { get; set; } 
    }
}
