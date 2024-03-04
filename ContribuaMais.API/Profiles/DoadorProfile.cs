using AutoMapper;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;

namespace ContribuaMais.API.Profiles
{
    public class DoadorProfile : Profile
    {
        public DoadorProfile()
        {
            CreateMap<DtoDoador, Doador>();
            CreateMap<Doador, DtoDoador>();
        }
    }
}