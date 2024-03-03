using AutoMapper;
using ContribuaMais.API.Models.Dados.Dtos.Infraestrutura;
using ContribuaMais.API.Models.Dados.Infraestrutura;

namespace ContribuaMais.API.Profiles.Infraestrutura
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<Pessoa, DtoPessoa>();
            CreateMap<DtoPessoa, Pessoa>();
        }
    }
}
