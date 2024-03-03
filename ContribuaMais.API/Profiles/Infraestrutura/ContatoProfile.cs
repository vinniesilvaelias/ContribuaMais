using AutoMapper;
using ContribuaMais.API.Models.Dados.Dtos.Infraestrutura;
using ContribuaMais.API.Models.Dados.Infraestrutura;

namespace ContribuaMais.API.Profiles.Infraestrutura
{
    public class ContatoProfile : Profile
    {
        public ContatoProfile()
        {
            CreateMap<Contato, DtoContato>();
            CreateMap<DtoContato, Contato>();
        }
    }
}
