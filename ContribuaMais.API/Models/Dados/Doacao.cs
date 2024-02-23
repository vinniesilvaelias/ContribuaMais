using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class Doacao : EntidadeBase
    {
        public Item Item { get; set; }
        public Doador Doador { get; set; }
        public Campanha Campanha { get; set; }
        public bool FoiEfetivada { get; set; }
        public int Quantidade { get; set; }
    }
}
