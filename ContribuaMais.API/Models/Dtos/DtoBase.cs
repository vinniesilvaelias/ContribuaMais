using ContribuaMais.API.Models.Interfaces;

namespace ContribuaMais.API.Models.Dtos
{
    public abstract class DtoBase : IDto
    {
        public int Codigo { get; set; }
    }
}
