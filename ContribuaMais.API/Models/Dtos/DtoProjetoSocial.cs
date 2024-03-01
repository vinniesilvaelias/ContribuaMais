using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Models.Dtos
{
    public class DtoProjetoSocial : DtoBase
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public IList<DtoCampanha> Campanhas { get; set; }
    }
}
