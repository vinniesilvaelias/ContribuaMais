using AutoMapper;
using ContribuaMais.API.Models.Dados.Dtos.Infraestrutura;
using ContribuaMais.API.Models.Dados.Infraestrutura;

namespace ContribuaMais.API.Profiles.Infraestrutura
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<Endereco, DtoEndereco>();
            CreateMap<DtoEndereco, Endereco>();
        }
    }
}
