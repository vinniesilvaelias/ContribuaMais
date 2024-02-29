using AutoMapper;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;

namespace ContribuaMais.API.Profiles
{
    public class DoacaoProfile : Profile
    {
        public DoacaoProfile()
        {
            CreateMap<DtoDoacao, Doacao>();
            CreateMap<Doacao, DtoDoacao>();
        }
    }
}
