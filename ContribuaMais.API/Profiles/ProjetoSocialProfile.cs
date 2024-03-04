using AutoMapper;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;

namespace ContribuaMais.API.Profiles
{
    public class ProjetoSocialProfile : Profile
    {
        public ProjetoSocialProfile()
        {
            //CreateMap<DtoProjetoSocial, ProjetoSocial>();
            //CreateMap<ProjetoSocial, DtoProjetoSocial>();

            CreateMap<DtoProjetoSocial, ProjetoSocial>()
                .ForMember(dest => dest.PessoaResponsavel,
                           opt => opt.MapFrom(src => src.PessoaResponsavel));
            CreateMap<ProjetoSocial, DtoProjetoSocial>()
                .ForMember(dest => dest.PessoaResponsavel, 
                           opt => opt.MapFrom(src => src.PessoaResponsavel));
        }
    }
}
