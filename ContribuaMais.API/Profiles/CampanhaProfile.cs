using AutoMapper;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;

namespace ContribuaMais.API.Profiles
{
    public class CampanhaProfile : Profile
    {
        public CampanhaProfile()
        {
            CreateMap<DtoCampanha, Campanha>();
            CreateMap<Campanha, DtoCampanha>();
        }
    }
}
