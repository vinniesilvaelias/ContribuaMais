using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Models.Dtos
{
    public class DtoDoacao : DtoBase
    {
        //public int CodigoItem { get; set; }
        //public int CodigoDoador { get; set; }
        //public int CodigoCampanha { get; set; }
        public DtoItem Item { get; set; }
        public DtoDoador Doador { get; set; }
        public DtoCampanha Campanha { get; set; }
        public bool FoiEfetivada { get; set; }
        public int Quantidade { get; set; }
    }
}
