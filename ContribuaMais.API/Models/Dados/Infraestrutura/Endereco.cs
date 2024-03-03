using ContribuaMais.API.Models.Dados.Infraestrutura.Enumeradores;
using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados.Infraestrutura
{
    public class Endereco : EntidadeBase, IEntidadeBase
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
