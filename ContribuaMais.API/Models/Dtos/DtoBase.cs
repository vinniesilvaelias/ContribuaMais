using ContribuaMais.API.Models.Interfaces;

namespace ContribuaMais.API.Models.Dtos
{
    public class DtoBase : IDto
    {
        public int Codigo { get; set; }
    }
}
