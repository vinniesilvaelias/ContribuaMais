using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class Campanha : EntidadeBase, IEntidadeBase
    {
        public string Descricao { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public bool EstaAtiva { get; set; }
        public bool EhPermanente { get; set; }
        public string Objetivo { get; set; }
        public string Arrecadado { get; set; }
    }
}
