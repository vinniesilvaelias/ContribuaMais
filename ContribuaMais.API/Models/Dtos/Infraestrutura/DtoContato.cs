using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Models.Interfaces;

namespace ContribuaMais.API.Models.Dados.Dtos.Infraestrutura
{
    public class DtoContato : DtoBase, IDto
    {
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? Facebook { get; set; }
        public string? Instragram { get; set; }
        public string? Linkedin { get; set; }
    }
}