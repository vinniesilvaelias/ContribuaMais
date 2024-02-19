using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class Doacao : EntidadeBase
    {
        //public Guid IdItem { get; set; }
        //public Guid IdDoador { get; set; }
        //public Guid IdCampanha { get; set; }
        public Item Item { get; set; }
        public Doador Doador { get; set; }
        public Campanha Campanha { get; set; }
        public bool FoiEfetivada { get; set; }
        public decimal Quantidade { get; set; }
    }
}
