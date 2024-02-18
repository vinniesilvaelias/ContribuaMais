using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class Doacao : EntidadeBase
    {
        public Guid IdItem { get; set; }
        public Guid IdDoador { get; set; }
        public Guid IdCampanha { get; set; }
        public bool FoiEfetivada { get; set; }
        public decimal Quantidade { get; set; }
    }
}
