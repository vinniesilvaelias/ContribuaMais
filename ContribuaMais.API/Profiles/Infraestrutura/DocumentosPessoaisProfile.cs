using AutoMapper;
using ContribuaMais.API.Models.Dados.Infraestrutura;
using ContribuaMais.API.Models.Dtos.Infraestrutura;

namespace ContribuaMais.API.Profiles.Infraestrutura
{
    public class DocumentosPessoaisProfile : Profile
    {
        public DocumentosPessoaisProfile()
        {
            CreateMap<DocumentosPessoais, DtoDocumentosPessoais>();
            CreateMap<DtoDocumentosPessoais, DocumentosPessoais>();
        }
    }
}
