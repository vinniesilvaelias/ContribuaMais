using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Models.Dtos
{
    public class DtoDoacao : DtoBase
    {
        public DtoItem Item { get; set; }
        public DtoDoador Doador { get; set; }
        public DtoCampanha Campanha { get; set; }
        public bool FoiEfetivada { get; set; }
        public int Quantidade { get; set; }
    }
}
