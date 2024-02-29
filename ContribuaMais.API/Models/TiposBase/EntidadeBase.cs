using ContribuaMais.API.Models.Interfaces;

namespace ContribuaMais.API.Models.TiposBase
{
    public class EntidadeBase : IEntidadeBase
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
    }
}
