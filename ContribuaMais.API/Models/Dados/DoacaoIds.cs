using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Models.Dados
{
    public class DoacaoIds
    {
        public Guid Item { get; set; }
        public Guid Doacao { get; set; }
        public Guid Doador { get; set; }
        public Guid Campanha { get; set; }
    }
}
