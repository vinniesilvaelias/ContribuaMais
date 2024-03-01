using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class ProjetoSocial : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public IList<Campanha> Campanhas { get; set; }
    }
}
