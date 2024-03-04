using AutoMapper;
using ContribuaMais.API.Models.Dados.Infraestrutura;
using ContribuaMais.API.Models.Dtos.Infraestrutura;
using ContribuaMais.API.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers.Infraestrutura
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentosPessoaisController : ControladorBase<DtoDocumentosPessoais, DocumentosPessoais>
    {
        public DocumentosPessoaisController(IServico<DocumentosPessoais> servico, IMapper mapper) : base(servico, mapper)
        {
        }
    }
}
