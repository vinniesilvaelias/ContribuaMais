namespace ContribuaMais.API.Models.Dtos
{
    public class DtoDoacao : DtoBase
    {
        public int CodigoItem { get; set; }
        public int CodigoDoador { get; set; }
        public int CodigoCampanha { get; set; }
    }
}
