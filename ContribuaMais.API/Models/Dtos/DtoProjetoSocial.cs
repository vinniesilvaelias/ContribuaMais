using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dados.Dtos.Infraestrutura;
using ContribuaMais.API.Models.Dados.Infraestrutura;

namespace ContribuaMais.API.Models.Dtos
{
    public class DtoProjetoSocial : DtoBase
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public DtoPessoa PessoaResponsavel { get; set; }
        public IList<DtoCampanha> Campanhas { get; set; }
    }
}
