using AutoMapper;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;

namespace ContribuaMais.API.Profiles
{
    public class ProjetoSocialProfile : Profile
    {
        public ProjetoSocialProfile()
        {
            CreateMap<DtoProjetoSocial, ProjetoSocial>();
            CreateMap<ProjetoSocial, DtoProjetoSocial>();
        }
    }
}
