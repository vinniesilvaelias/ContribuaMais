using ContribuaMais.API.Models.Enumeradores;
using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class Item : EntidadeBase, IEntidadeBase
    {
        public string Decricao { get; set; }
        public EnumTipoItem Tipo { get; set; }
    }
}
