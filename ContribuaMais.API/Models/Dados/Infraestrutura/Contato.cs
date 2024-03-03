using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados.Infraestrutura
{
    public class Contato : EntidadeBase, IEntidadeBase
    {
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? Facebook { get; set; }
        public string? Instragram { get; set; }
        public string? Linkedin { get; set; }
    }
}