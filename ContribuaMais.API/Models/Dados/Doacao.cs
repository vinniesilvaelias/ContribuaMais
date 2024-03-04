using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class Doacao : EntidadeBase, IEntidadeBase
    {
        public Item Item { get; set; }
        public Doador Doador { get; set; }
        public Campanha Campanha { get; set; }
        public bool FoiEfetivada { get; set; }
        public string Quantidade { get; set; }
        public DateTime Data { get; set; }
    }
}
